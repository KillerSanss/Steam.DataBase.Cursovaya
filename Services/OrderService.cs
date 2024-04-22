using steam.Infrastructure.Context;
using steam.Infrastructure.Entities;

namespace steam.Services
{
    /// <summary>
    /// Сервис для Order
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="orderDate">Дата заказа.</param>
        /// <param name="price">Цена.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <returns>Заказ.</returns>
        public static Order Create(
            DateTime orderDate,
            double price,
            Guid userId,
            Guid productId)
        {
            return new Order
            {
                OrderDate = orderDate,
                Price = price,
                UserId = userId,
                ProductId = productId
            };
        }

        /// <summary>
        /// Получение списка всех заказов
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="userid">Идентификатор пользователя.</param>
        /// <returns>Список заказов пользователя.</returns>
        public static List<Order> GetAllByUserId(
            SteamDbContext _dbContext,
            Guid userid)
        {
            List<Order> orders = new List<Order>();

            foreach (var order in _dbContext.Orders)
            {
                if (order.UserId == userid)
                {
                    orders.Add(order);
                }
            }

            return orders;
        }
    }
}
