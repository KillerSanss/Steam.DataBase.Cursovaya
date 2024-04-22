using steam.Infrastructure.Context;
using steam.Validations.Errors;

namespace steam
{
    /// <summary>
    /// Форма для входа
    /// </summary>
    public partial class Form4 : Form
    {
        private readonly SteamDbContext _dbContext;

        public Form4(SteamDbContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;
        }

        /// <summary>
        /// Вход
        /// </summary>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string nickName = NickNameField.Text;
            string password = PasswordField.Text;

            var user = _dbContext.Users.FirstOrDefault(u => u.NickName == nickName && u.Password == password);
            var admin = _dbContext.Admins.FirstOrDefault(a => a.NickName == nickName && a.Password == password);

            if (user == null && admin == null)
            {
                MessageBox.Show(ErrorMessages.InvalidLoginOrPassword);
            }
            else
            {
                if (IsAdmin.Checked && admin != null)
                {
                    Form11 form = new Form11(_dbContext, nickName);
                    form.Show();
                    Hide();
                }
                else
                {
                    if (IsAdmin.Checked && admin == null)
                    {
                        MessageBox.Show("Такого администратора не существует!");
                    }
                    else
                    {
                        Form3 form = new Form3(_dbContext, nickName);
                        form.Show();
                        Hide();
                    }
                }
            }
        }

        /// <summary>
        /// Переход на окно регистрации
        /// </summary>
        private void StartRegistrationButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(_dbContext);
            form.Show();
            Hide();
        }
    }
}
