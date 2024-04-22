using steam.Infrastructure.Context;
using steam.Infrastructure.Enums;
using steam.Services;
using steam.Validations.EntityValidaitons;
using steam.Validations.Errors;
using steam.Validations;

namespace steam
{
    /// <summary>
    /// Форма дял разработки продукта
    /// </summary>
    public partial class Form8 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form8(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickName;
        }

        /// <summary>
        /// Опубликовать продукт
        /// </summary>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            string title = TitleField.Text;
            string description = DescriptionField.Text;
            DateTime dateOfDevelopment = DateTime.Now.ToUniversalTime();
            Category category = Category.None;
            double price = Convert.ToDouble(PriceField.Value);

            switch (CategoryBox.Text)
            {
                case "Game":
                    {
                        category = Category.Game;
                        break;
                    }
                case "Software":
                    {
                        category = Category.Software;
                        break;
                    }
            }

            if (Validations(title, description, price))
            {
                var newProduct = ProductService.Create(
               title,
               description,
               dateOfDevelopment,
               category,
               price,
               currentUser.Id);

                _dbContext.Products.AddRange(newProduct);
                _dbContext.SaveChanges();

                MessageBox.Show("Продукт опубликован!");
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
        /// <param name="title">Название.</param>
        /// <param name="description">Описание.</param>
        /// <param name="price">Цена.</param>
        /// <returns>Результат валидации.</returns>
        public bool Validations(string title, string description, double price)
        {
            if (Validators.ValidateString(title, nameof(title), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidTitle) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(title, nameof(title), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidTitle));
                return false;
            }

            if (Validators.ValidateString(description, nameof(description), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidDescription) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateString(description, nameof(description), RegularExpresions.SymbolsPattern, ErrorMessages.InvalidDescription));
                return false;
            }

            if (Validators.ValidateDouble(price, nameof(price), ErrorMessages.InvalidPrice) != string.Empty)
            {
                MessageBox.Show(Validators.ValidateDouble(price, nameof(price), ErrorMessages.InvalidPrice));
                return false;
            }
            return true;
        }
    }
}
