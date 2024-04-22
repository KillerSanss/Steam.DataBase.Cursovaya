using steam.Infrastructure.Context;
using steam.Infrastructure.Enums;
using steam.Services;

namespace steam
{
    /// <summary>
    /// Форма для магазина
    /// </summary>
    public partial class Form6 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form6(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickName;

            var products = ProductService.GetAll(_dbContext);

            foreach (var product in products)
            {
                Products.Items.Add(product.Title);
                Prices.Items.Add(product.Price + "$");
            }

            var currentUser = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            if (currentUser.Role == Role.Developer)
            {
                BuyButton.Visible = false;
            }
        }

        /// <summary>
        /// Покупка выбранного товара
        /// </summary>
        private void BuyButton_Click(object sender, EventArgs e)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(u => u.NickName == _nickName);

            if (Products.SelectedItems.Count != 0)
            {
                var selectedItem = Products.SelectedItem.ToString();
                var selectedProduct = _dbContext.Products.FirstOrDefault(p => p.Title == selectedItem);

                if (selectedProduct != null)
                {
                    double price = selectedProduct.Price;
                    if (currentUser.Ballance < price)
                    {
                        MessageBox.Show("Не хватает денег на счету!");
                    }
                    else
                    {
                        var order = OrderService.Create(
                        DateTime.Now.ToUniversalTime(),
                        price,
                        currentUser.Id,
                        selectedProduct.Id);

                        var user = _dbContext.Users.FirstOrDefault(u => u.Id == currentUser.Id);
                        user.Ballance -= price;

                        var developer = _dbContext.Users.FirstOrDefault(d => d.Id == selectedProduct.UserId);
                        developer.Ballance += price;

                        _dbContext.Users.UpdateRange(developer, user);
                        _dbContext.Orders.AddRange(order);
                        _dbContext.SaveChanges();

                        MessageBox.Show("Спасибо за покупку!");

                        var products = ProductService.GetAll(_dbContext);
                        Products.Items.Clear();
                        Prices.Items.Clear();

                        foreach (var product in products)
                        {
                            Products.Items.Add(product.Title);
                            Prices.Items.Add(product.Price + "$");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Продукт не выбран!");
                }
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
        /// Сортировать
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            double minPrice = Convert.ToDouble(MinimumPriceField.Value);
            double maхPrice = Convert.ToDouble(MaximumPriceField.Value);
            Category category = Category.None;
            DateTime minDate = MinimumDateField.Value;
            DateTime maxDate = MaximumDateField.Value;

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

            var products = ProductService.GetAllWhere(
                _dbContext,
                minPrice,
                maхPrice,
                category,
                minDate,
                maxDate);

            Products.Items.Clear();
            Prices.Items.Clear();

            foreach (var product in products)
            {
                Products.Items.Add(product.Title);
                Prices.Items.Add(product.Price + "$");
            }
        }

        /// <summary>
        /// Отменить сортировку
        /// </summary>
        private void CanselSortButton_Click(object sender, EventArgs e)
        {
            Products.Items.Clear();
            Prices.Items.Clear();
            var products = ProductService.GetAll(_dbContext);
            foreach (var product in products)
            {
                Products.Items.Add(product.Title);
                Prices.Items.Add(product.Price + "$");
            }
        }

        /// <summary>
        /// Посмотреть подробную информацию о товаре
        /// </summary>
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
