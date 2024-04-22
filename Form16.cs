using steam.Infrastructure.Context;

namespace steam
{
    /// <summary>
    /// Форма для подробностей товара
    /// </summary>
    public partial class Form16 : Form
    {
        private readonly SteamDbContext _dbContext;

        public Form16(SteamDbContext dbContext, string selectedProduct)
        {
            InitializeComponent();
            _dbContext = dbContext;

            var product = _dbContext.Products.FirstOrDefault(p => p.Title == selectedProduct);

            if (product != null)
            {
                Title.Text = product.Title;
                Description.Text = product.Description;
                DateOfDevelopment.Text = product.DateOfDevelopment.ToString();
                var developer = _dbContext.Users.FirstOrDefault(u => u.Id == product.UserId);
                Developer.Text = developer?.NickName;
            }
        }

        /// <summary>
        /// Вернуться на главную страницу
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
