using steam.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace steam.Infrastructure.Entities
{
    /// <summary>
    /// Сущность продукта
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Название
        /// </summary>
        [Column("title")]
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [Column("description")]
        public string Description { get; set; }

        /// <summary>
        /// Дата разработки
        /// </summary>
        [Column("date_of_development")]
        [DataType("date")]
        public DateTime DateOfDevelopment { get; set; }

        /// <summary>
        /// Категория товара
        /// </summary>
        [Column("category")]
        public Category Category { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [Column("price")]
        public double Price { get; set; }

        /// <summary>
        /// Идентификатор разработчика
        /// </summary>
        [Column("user_id")]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Навигационное поле для User 
        /// </summary>
        public User User { get; set; }
    }
}
