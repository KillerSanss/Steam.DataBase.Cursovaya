using steam.Infrastructure.Context;
using steam.Infrastructure.Entities;
using steam.Infrastructure.Enums;

namespace steam.Services
{
    /// <summary>
    /// Сервис для Product
    /// </summary>
    public class ProductService
    {
        /// <summary>
        /// Создание продукта
        /// </summary>
        /// <param name="title">Название продукта.</param>
        /// <param name="description">Описание продукта.</param>
        /// <param name="dateOfDevelopment">Дата разработки.</param>
        /// <param name="category">Категория продукта.</param>
        /// <param name="price">Цена.</param>
        /// <param name="userid">Идентификатор разработчика.</param>
        /// <returns>Продукт.</returns>
        public static Product Create(
            string title,
            string description,
            DateTime dateOfDevelopment,
            Category category,
            double price,
            Guid userid)
        {
            return new Product
            {
                Title = title,
                Description = description,
                DateOfDevelopment = dateOfDevelopment,
                Category = category,
                Price = price,
                UserId = userid
            };
        }

        /// <summary>
        /// Получение списка всех продуктов разработчика
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="userId">Идентификатор разработчика.</param>
        /// <returns>Список продуктов разработчика.</returns>
        public static List<Product> GetAllByDeveloperId(
            SteamDbContext _dbContext,
            Guid userId)
        {
            List<Product> products = new List<Product>();

            foreach (var product in _dbContext.Products)
            {
                if (product.UserId == userId)
                {
                    products.Add(product);
                }
            }

            return products;
        }

        /// <summary>
        /// Получение списка всех продуктов
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <returns>Список продуктов.</returns>
        public static List<Product> GetAll(
            SteamDbContext _dbContext)
        {
            List<Product> products = new List<Product>();

            foreach (var product in _dbContext.Products)
            {
                products.Add(product);
            }

            return products;
        }

        /// <summary>
        /// Получение всех продуктов удовлетворяющих условию
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="minPrice">Минимальная цена.</param>
        /// <param name="maxPrice">Максимальная цена.</param>
        /// <param name="category">Категория товара.</param>
        /// <param name="minDate">Манимальная дата разрабоки.</param>
        /// <param name="maxDate">Максимальная дата разработки.</param>
        /// <returns>Список продуктов удовлетворяющие условию.</returns>
        public static List<Product> GetAllWhere(
            SteamDbContext _dbContext,
            double minPrice,
            double maxPrice,
            Category category,
            DateTime minDate,
            DateTime maxDate)
        {
            List<Product> products = new List<Product>();

            foreach (var product in _dbContext.Products)
            {
                if (
                    product.Price >= minPrice 
                    && product.Price <= maxPrice
                    && product.Category == category
                    && product.DateOfDevelopment >= minDate
                    && product.DateOfDevelopment <= maxDate)
                {
                    products.Add(product);
                }
            }

            return products;
        }

        /// <summary>
        /// Получение продукта по идентификатору
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <returns>Продукт.</returns>
        public static Product GetById(
            SteamDbContext _dbContext,
            Guid productId)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == productId);

            return product;
        }
    }
}
