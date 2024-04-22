using steam.Infrastructure.Context;
using steam.Infrastructure.Entities;
using steam.Infrastructure.Enums;
using steam.Services;

namespace steam
{
    /// <summary>
    /// Форма для домашней страницы
    /// </summary>
    public partial class Form3 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form3(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            DevelopButton.Visible = false;

            _dbContext = dbContext;
            _nickName = nickName;

            var currentUser = _dbContext.Users.FirstOrDefault(u => u.NickName == nickName);

            if (currentUser.Role == Role.User)
            {
                ProductsLabel.Text = "Приобритенные продукты";
                var orders = OrderService.GetAllByUserId(_dbContext, currentUser.Id);
                var products = _dbContext.Products.ToList();
                var userProduct = new List<Product>();

                foreach (var product in products)
                {
                    foreach (var order in orders)
                    {
                        if (product.Id == order.ProductId)
                        {
                            userProduct.Add(product);
                        }
                    }
                }

                ProfileButton.Text = currentUser.NickName;

                foreach (var product in userProduct)
                {
                    Products.Items.Add(product.Title);
                }
            }

            else if (currentUser.Role == Role.Developer)
            {
                ProductsLabel.Text = "Разработанные продукты";

                var developerProducts = ProductService.GetAllByDeveloperId(_dbContext, currentUser.Id);

                foreach (var product in developerProducts)
                {
                    Products.Items.Add(product.Title);
                }

                DevelopButton.Visible = true;
                ProfileButton.Text = currentUser.NickName;
            }

            if (currentUser.Ballance > 0)
            {
                MoneyField.Text = (Convert.ToDouble(MoneyField.Text) + currentUser.Ballance) + "$";
            }
            else
            {
                MoneyField.Text = currentUser.Ballance + "$";
            }
        }

        /// <summary>
        /// Изменить данные об аккаунте
        /// </summary>
        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(_dbContext, _nickName);
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
        /// Переход в магазин
        /// </summary>
        private void ShopButton_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Задать вопрос
        /// </summary>
        private void AskButton_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Привязать карту
        /// </summary>
        private void ConnectCardButton_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Разработь продукт
        /// </summary>
        private void DevelopButton_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8(_dbContext, _nickName);
            form.Show();
            Hide();
        }

        /// <summary>
        /// Посмотреть подробную информацию о продукте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreInformationButton_Click(object sender, EventArgs e)
        {
            var selectedProduct = Products.SelectedItem.ToString();

            if (selectedProduct == null)
            {
                MessageBox.Show("Продукт не выбран!");
            }
            else
            {
                Form16 form = new Form16(_dbContext, selectedProduct);
                form.Show();
            }
        }
    }
}
