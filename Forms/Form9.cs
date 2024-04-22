using steam.Infrastructure.Context;
using steam.Services;
using steam.Validations.EntityValidaitons;
using steam.Validations.Errors;
using steam.Validations;

namespace steam
{
    /// <summary>
    /// Форма для добавления карты
    /// </summary>
    public partial class Form9 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form9(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickName;
        }

        /// <summary>
        /// Привязать карту
        /// </summary>
        private void ConnectCardButton_Click(object sender, EventArgs e)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            string cardNumber = CardNumberField.Text;
            DateTime experationDate = Convert.ToDateTime(ExperationDateField.Text).ToUniversalTime();
            string nameOnCard = NameOnCardField.Text;
            string cvv = CVVField.Text;
            double ballance = new Random().Next(0, 100);

            if (currentUser.CardId == null)
            {
                if (Validations(cardNumber, nameOnCard, cvv, experationDate))
                {
                    var newCard = CardService.Create(
                    cardNumber,
                    experationDate,
                    nameOnCard,
                    cvv,
                    ballance,
                    currentUser.Id);

                    currentUser.Ballance += ballance;
                    newCard.Ballance = 0;

                    _dbContext.Cards.Add(newCard);

                    var user = UserService.Update(currentUser,
                        currentUser.Name,
                        currentUser.NickName,
                        currentUser.Password,
                        currentUser.Email,
                        currentUser.Phone,
                        currentUser.Ballance,
                        newCard.Id);

                    _dbContext.Users.Update(user);
                    _dbContext.SaveChanges();

                    MessageBox.Show($"Карта успешно привязана! Вы можете использовать все {ballance}$ с карты");
                }
            }
            else if (_dbContext.Cards.FirstOrDefault(c => c.Number == cardNumber) != null)
            {
                MessageBox.Show("Эта карта уже используется другим пользователем");
            }
            else
            {
                MessageBox.Show("К этому пользователю уже привязана карта");
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
        /// Валидация
        /// </summary>
        /// <param name="cardNumber">Номер карты.</param>
        /// <param name="nameOnCard">Имя на карте.</param>
        /// <param name="cvv">Код на обратной стороне.</param>
        /// <param name="experationDate">Дата просрочки карты.</param>
        /// <returns>Результат валидации.</returns>
        public bool Validations(string cardNumber, string nameOnCard, string cvv, DateTime experationDate)
        {
            if (Validators.ValidateString(cardNumber, nameof(cardNumber), RegularExpresions.CardNumberPattern, ErrorMessages.InvalidCardNumber) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(cardNumber, nameof(cardNumber), RegularExpresions.CardNumberPattern, ErrorMessages.InvalidCardNumber));
                return false;
            }

            if (Validators.ValidateString(nameOnCard, nameof(nameOnCard), RegularExpresions.OnlyLettersPattern, ErrorMessages.InvalidName) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(nameOnCard, nameof(nameOnCard), RegularExpresions.OnlyLettersPattern, ErrorMessages.InvalidName));
                return false;
            }

            if (Validators.ValidateString(cvv, nameof(cvv), RegularExpresions.CvvPattern, ErrorMessages.InvalidCvv) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(cvv, nameof(cvv), RegularExpresions.CvvPattern, ErrorMessages.InvalidCvv));
                return false;
            }

            if (Validators.ValidateDate(experationDate, nameof(experationDate), ErrorMessages.InvalidDate) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateDate(experationDate, nameof(experationDate), ErrorMessages.InvalidDate));
                return false;
            }
            return true;
        }
    }
}
