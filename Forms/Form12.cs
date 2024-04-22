using steam.Infrastructure.Context;
using steam.Infrastructure.Enums;
using steam.Services;

namespace steam
{
    /// <summary>
    /// Форма для админ панели магазина
    /// </summary>
    public partial class Form12 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form12(SteamDbContext dbContext, string nickname)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickname;

            var products = ProductService.GetAll(_dbContext)
            .Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.DateOfDevelopment,
                p.Category,
                p.Price,
                p.UserId, 
            }).ToList();

            ProductList.DataSource = products;
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
                maxDate)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.DateOfDevelopment,
                    p.Category,
                    p.Price,
                    p.UserId,
                }).ToList();

            ProductList.DataSource = products;
        }

        /// <summary>
        /// Отменить сортировку
        /// </summary>
        private void CancelSortButton_Click(object sender, EventArgs e)
        {
            var products = ProductService.GetAll(_dbContext)
            .Select(p => new
            {
                p.Id,
                p.Title,
                p.Description,
                p.DateOfDevelopment,
                p.Category,
                p.Price,
                p.UserId,
            }).ToList();
            ProductList.DataSource = products;
        }

        /// <summary>
        /// Удалить товар из магазина
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedRows.Count > 0)
            {
                Guid selectedProductId = (Guid)ProductList.SelectedRows[0].Cells["Id"].Value;

                var productToDelete = ProductService.GetById(_dbContext, selectedProductId);

                _dbContext.Products.RemoveRange(productToDelete);
                _dbContext.SaveChanges();

                MessageBox.Show("Продукт был удален!");

                var products = ProductService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Title,
                    p.Description,
                    p.DateOfDevelopment,
                    p.Category,
                    p.Price,
                    p.UserId,
                }).ToList();
                ProductList.DataSource = products;
            }
        }

        /// <summary>
        /// Вернуться на главную страницу
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11(_dbContext, _nickName);
            form.Show();
            Hide();
        }
    }
}
