using steam.Infrastructure.Context;
using steam.Validations.EntityValidaitons;
using steam.Validations.Errors;
using steam.Validations;

namespace steam
{
    /// <summary>
    /// Обновление данных об аккаунте
    /// </summary>
    public partial class Form5 : Form
    {
        private readonly SteamDbContext _dbContext;
        private string _nickName;

        public Form5(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickName;

            var user = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            NameField.Text = user.Name;
            NickNameField.Text = user.NickName;
            PasswordField.Text = user.Password;
            EmailField.Text = user.Email;
            PhoneField.Text = user.Phone; 
        }

        /// <summary>
        /// Подтвердить изменения
        /// </summary>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            string name = NameField.Text;
            string nickName = NickNameField.Text;
            string password = PasswordField.Text;
            string email = EmailField.Text;
            string phone = PhoneField.Text;
            double ballance = user.Ballance;

            if (Validations(nickName, name, password, email, phone))
            {
                user = UserService.Update(
                    user,
                    name,
                    nickName,
                    password,
                    email,
                    phone,
                    ballance,
                    null);

                _dbContext.Users.UpdateRange(user);
                _dbContext.SaveChanges();

                _nickName = nickName;

                MessageBox.Show("Изменения успешно применены!");
            }
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
            if (Validators.ValidateString(nickName, nameof(nickName), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidNickName) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(nickName, nameof(nickName), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidNickName));
                return false;
            }

            if (Validators.ValidateString(name, nameof(name), RegularExpresions.OnlyLettersPattern, ErrorMessages.InvalidName) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(name, nameof(name), RegularExpresions.OnlyLettersPattern, ErrorMessages.InvalidName));
                return false;
            }

            if (Validators.ValidateString(password, nameof(password), RegularExpresions.PasswordPattern, ErrorMessages.InvalidPassword) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(password, nameof(password), RegularExpresions.PasswordPattern, ErrorMessages.InvalidPassword));
                return false;
            }

            if (Validators.ValidateString(email, nameof(email), RegularExpresions.EmailPattern, ErrorMessages.InvalidEmail) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString   (password, nameof(password), RegularExpresions.PasswordPattern, ErrorMessages.InvalidPassword));
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
