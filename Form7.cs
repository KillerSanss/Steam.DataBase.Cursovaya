using steam.Infrastructure.Context;
using steam.Services;
using steam.Infrastructure.Enums;

namespace steam
{
    /// <summary>
    /// Форма для вопросов
    /// </summary>
    public partial class Form7 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;


        public Form7(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            _dbContext = dbContext;

            _nickName = nickName;

            var questions = QuestionService.GetAll(_dbContext);

            Questions.Items.Clear();
            Statuses.Items.Clear();

            foreach (var question in questions)
            {
                Questions.Items.Add(question.Title);
                Statuses.Items.Add(question.Status);
            }
        }

        /// <summary>
        /// Задать вопрос
        /// </summary>
        private void AskButton_Click_1(object sender, EventArgs e)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            string title = TitleField.Text;
            string description = DescriptionField.Text;
            DateTime creationDate = DateTime.Now.ToUniversalTime();
            Status status = Status.Active;

            var question = QuestionService.Create(
                title,
                description,
                creationDate,
                status,
                currentUser.Id);

            _dbContext.Questions.AddRange(question);
            _dbContext.SaveChanges();

            MessageBox.Show("Вопрос был создан!");

            var questions = QuestionService.GetAll(_dbContext);

            Questions.Items.Clear();
            Statuses.Items.Clear();

            foreach (var quest in questions)
            {
                Questions.Items.Add(question.Title);
                Statuses.Items.Add(question.Status);
            }
        }

        /// <summary>
        /// Сортировка
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
                maxDate);

            Questions.Items.Clear();
            Statuses.Items.Clear();

            foreach (var question in questions)
            {
                Questions.Items.Add(question.Title);
                Statuses.Items.Add(question.Status);
            }
        }

        /// <summary>
        /// Отменить сортировку
        /// </summary>
        private void CancelSortButton_Click(object sender, EventArgs e)
        {
            Questions.Items.Clear();
            Statuses.Items.Clear();
            var questions = QuestionService.GetAll(_dbContext);
            foreach (var question in questions)
            {
                Questions.Items.Add(question.Title);
                Statuses.Items.Add(question.Status);
            };
        }

        /// <summary>
        /// Вернуться на домашнюю страницу
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Посмотреть подробную информацию о вопросе
        /// </summary>
        private void MoreInformationButton_Click(object sender, EventArgs e)
        {
            var selectedQuestion = Questions.SelectedItem.ToString();

            if (selectedQuestion == null)
            {
                MessageBox.Show("Вопрос не выбран!");
            }
            else
            {
                Form17 form = new Form17(_dbContext, selectedQuestion);
                form.Show();
            }
        }
    }
}
