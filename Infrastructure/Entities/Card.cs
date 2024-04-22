using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace steam.Infrastructure.Entities
{
    /// <summary>
    /// Сущность карты
    /// </summary>
    public class Card : BaseEntity
    {
        /// <summary>
        /// Номер карты
        /// </summary>
        [Column("number")]
        public string Number { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        [Column("experaation_date")]
        [DataType("date")]
        public DateTime ExperationDate { get; set; }

        /// <summary>
        /// Имя на карте
        /// </summary>
        [Column("name_on_card")]
        public string NameOnCard { get; set; }

        /// <summary>
        /// Код карты
        /// </summary>
        [Column("cvv")]
        public string CVV { get; set; }

        /// <summary>
        /// Балланс на карте
        /// </summary>
        [Column("ballance")]
        public double Ballance { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Column("user_id")]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; } 
    }

    public class Class2
    {
    }
}
