using steam.Infrastructure.Context;

namespace steam
{
    /// <summary>
    /// Форма для подробной информации о вопросе
    /// </summary>
    public partial class Form17 : Form
    {
        private readonly SteamDbContext _dbContext;

        public Form17(SteamDbContext dbContext, string selectedQuestion)
        {
            InitializeComponent();

            _dbContext = dbContext;

            var question = _dbContext.Questions.FirstOrDefault(q => q.Title == selectedQuestion);

            if (question != null)
            {
                TitleLabel.Text = question.Title;
                DescriptionField.Text = question.Description;
                CreationDateLabel.Text = question.CreationDate.ToString();
                var user = _dbContext.Users.FirstOrDefault(u => u.Id == question.UserId);
                UserLabel.Text = user.NickName;
            }
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
