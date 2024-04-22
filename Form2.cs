using steam.Infrastructure.Context;
using steam.Infrastructure.Enums;
using steam.Validations;
using steam.Validations.EntityValidaitons;
using steam.Validations.Errors;

namespace steam
{
    /// <summary>
    /// Форма для регистриции
    /// </summary>
    public partial class Form2 : Form
    {
        private readonly SteamDbContext _dbContext;

        public Form2(SteamDbContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;
        }

        /// <summary>
        /// Завершение регистрации
        /// </summary>
        private void EndRegistrationButton_Click(object sender, EventArgs e)
        {
            string nickName = NickNameField.Text;
            string name = NameField.Text;
            string password = PasswordField.Text;
            string email = EmailField.Text;
            string phone = PhoneField.Text;
            DateTime registrationDate = DateTime.Now.ToUniversalTime();
            Role role = Role.User;
            double ballnce = 0;

            if (IsDeveloper.Checked)
            {
                role = Role.Developer;
            }

            if (Validations(nickName, name, password, email, phone))
            {
                var newUser = UserService.Create(
                    name,
                    nickName,
                    password,
                    email,
                    phone,
                    role,
                    registrationDate,
                    ballnce);

                _dbContext.Users.AddRange(newUser);
                _dbContext.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!");
            }
        }

        /// <summary>
        /// Вернуться на главную страницу
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(_dbContext);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Валидация полей
        /// </summary>
        /// <param name="nickName">Никнейм.</param>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <returns>Результат валидации.</returns>
        public bool Validations(string nickName, string name, string password, string email, string phone)
        {
            if (Validators.ValidateString(name, nameof(name), RegularExpresions.OnlyLettersPattern, ErrorMessages.InvalidName) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(name, nameof(name), RegularExpresions.OnlyLettersPattern, ErrorMessages.InvalidName));
                return false;
            }

            if (Validators.ValidateString(nickName, nameof(nickName), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidNickName) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(nickName, nameof(nickName), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidNickName));
                return false;
            }

            if (Validators.ValidateString(password, nameof(password), RegularExpresions.PasswordPattern, ErrorMessages.InvalidPassword) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(password, nameof(password), RegularExpresions.PasswordPattern, ErrorMessages.InvalidPassword));
                return false;
            }

            if (Validators.ValidateString(email, nameof(email), RegularExpresions.EmailPattern, ErrorMessages.InvalidEmail) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(password, nameof(password), RegularExpresions.PasswordPattern, ErrorMessages.InvalidPassword));
                return false;
            }

            if (Validators.ValidateString(phone, nameof(phone), RegularExpresions.PhonePattern, ErrorMessages.InvalidPhone) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(phone, nameof(phone), RegularExpresions.PhonePattern, ErrorMessages.InvalidPhone));
                return false;
            }
            return true;
        }
    }
}
