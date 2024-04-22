using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace steam.Infrastructure.Entities
{
    /// <summary>
    /// Сущность заказа
    /// </summary>
    public class Order : BaseEntity
    {
        /// <summary>
        /// Дата заказа
        /// </summary>
        [Column("order_date")]
        [DataType("date")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [Column("price")]
        public double Price { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        [Column("product_id")]
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Column("user_id")]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Навигационное поле для User
        /// </summary>
        [NotMapped]
        public User User { get; set; }
    }
}
