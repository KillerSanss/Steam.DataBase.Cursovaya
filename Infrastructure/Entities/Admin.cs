using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace steam.Infrastructure.Entities
{
    /// <summary>
    /// Сущность администратора
    /// </summary>
    public class Admin : BaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Никнейм
        /// </summary>
        [Column("nick_name")]
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
        /// Дата регистрации
        /// </summary>
        [Column("registration_date")]
        [DataType("date")]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Связанные вопросы
        /// </summary>
        public ICollection<Question> Questions { get; set; }
    }
}
