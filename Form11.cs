using steam.Infrastructure.Context;

namespace steam
{
    /// <summary>
    /// Форма для админ панели
    /// </summary>
    public partial class Form11 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form11(SteamDbContext dbContext, string nickname)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickname;

            NickNameField.Text = nickname;
        }

        /// <summary>
        /// Управлять списком продуктор
        /// </summary>
        private void StoreManagingButton_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Управлять списком вопросов
        /// </summary>
        private void QuestionManagingButton_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Управлять списком карт
        /// </summary>
        private void CardManagingButton_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Выйти из аккаунта
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(_dbContext);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Управление списком пользователй
        /// </summary>
        private void UserManagingButton_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15(_dbContext, _nickName);
            form.Show();
            Hide();
        }
    }
}
