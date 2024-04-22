using steam.Infrastructure.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace steam.Infrastructure.Entities
{
    /// <summary>
    /// Сущность пользователя
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Никнейм
        /// </summary>
        [Column("nickname")]
        public string NickName { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Column("password")]
        public string Password { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        [Column("email")]
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        [Column("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Идентификатор роли
        /// </summary>
        [Column("role")]
        [DefaultValue(Role.None)]
        public Role Role { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        [Column("registration_date")]
        [DataType("date")]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Балланс на счету 
        /// </summary>
        [Column("ballance")]
        public double Ballance { get; set; }

        /// <summary>
        /// Идентификатор карты
        /// </summary>
        [Column("card_id")]
        [ForeignKey("CardId")]
        public Guid? CardId { get; set; }

        /// <summary>
        /// Навигационное поле для Card
        /// </summary>
        [NotMapped]
        public Card? Card { get; set; }

        /// <summary>
        /// Заданные вопросы
        /// </summary>
        [NotMapped]
        public ICollection<Question> Questions { get; set; }

        /// <summary>
        /// Заказы
        /// </summary>
        [NotMapped]
        public ICollection<Order> Orders { get; set; }

        /// <summary>
        /// Разработанные продукты
        /// </summary>
        [NotMapped]
        public ICollection<Product> DevelopedProducts { get; set; }

        /// <summary>
        /// Купленные продукты
        /// </summary>
        [NotMapped]
        public ICollection<Product> Products { get; set; }
    }
}
