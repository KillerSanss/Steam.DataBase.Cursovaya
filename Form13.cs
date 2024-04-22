using steam.Infrastructure.Context;
using steam.Infrastructure.Enums;
using steam.Services;

namespace steam
{
    /// <summary>
    /// Форма для админ панели вопросов
    /// </summary>
    public partial class Form13 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form13(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickName;

            var questions = QuestionService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.CreationDate,
                    p.Status,
                    p.Answer,
                    p.UserId,
                }).ToList();
            Questions.DataSource = questions;
        }

        /// <summary>
        /// Сортировать
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            Status status = Status.None;
            DateTime minDate = MinimumDateField.Value;
            DateTime maxDate = MaximumDateField.Value;

            switch (StatusBox.Text)
            {
                case "Active":
                    {
                        status = Status.Active;
                        break;
                    }

                case "Resolved":
                    {
                        status = Status.Resolved;
                        break;
                    }
            }

            var questions = QuestionService.GetAllWhere(
                _dbContext,
                status,
                minDate,
                maxDate)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.CreationDate,
                    p.Status,
                    p.Answer,
                    p.UserId,
                }).ToList();

            Questions.DataSource = questions;
        }

        /// <summary>
        /// Отменить сортировку
        /// </summary>
        private void CancelSortButton_Click(object sender, EventArgs e)
        {
            var questions = QuestionService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.CreationDate,
                    p.Status,
                    p.Answer,
                    p.UserId,
                }).ToList();
            Questions.DataSource = questions;
        }

        /// <summary>
        /// Удалить вопрос
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Questions.SelectedRows.Count > 0)
            {
                Guid selectedQuestionId = (Guid)Questions.SelectedRows[0].Cells["Id"].Value;

                var questionToDelete = QuestionService.GetById(_dbContext, selectedQuestionId);

                _dbContext.Questions.RemoveRange(questionToDelete);
                _dbContext.SaveChanges();

                MessageBox.Show("Вопрос был удален!");

                var questions = QuestionService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.CreationDate,
                    p.Status,
                    p.Answer,
                    p.UserId,
                }).ToList();

                Questions.DataSource = questions;
                
            }
        }

        /// <summary>
        /// Ответить на вопрос
        /// </summary>
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (Questions.SelectedRows.Count > 0)
            {
                Guid selectedQuestionId = (Guid)Questions.SelectedRows[0].Cells["Id"].Value;

                var questionToAnswer = QuestionService.GetById(_dbContext, selectedQuestionId);
                string answer = AnswerField.Text;
                var admin = _dbContext.Admins.FirstOrDefault(a => a.NickName == _nickName);

                var question = QuestionService.Update(questionToAnswer, answer, admin.Id);

                _dbContext.Questions.UpdateRange(question);
                _dbContext.SaveChanges();

                var questions = QuestionService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.CreationDate,
                    p.Status,
                    p.Answer,
                    p.UserId,
                }).ToList();
                Questions.DataSource = questions;
            }
        }

        /// <summary>
        /// Верунться
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11(_dbContext, _nickName);
            form.Show();
            Hide();
        }
    }
}
