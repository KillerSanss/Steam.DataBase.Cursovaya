using steam.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace steam.Infrastructure.Entities
{
    /// <summary>
    /// Сущность вопроса
    /// </summary>
    public class Question : BaseEntity
    {
        /// <summary>
        /// Название вопроса
        /// </summary>
        [Column("title")]
        public string Title { get; set; }

        /// <summary>
        /// Описание вопроса
        /// </summary>
        [Column("description")]
        public string Description { get; set; }

        /// <summary>
        /// Ответ на вопрос
        /// </summary>
        [Column("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        [Column("creation_date")]
        [DataType("date")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        [Column("status")]
        public Status Status { get; set; }

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

        /// <summary>
        /// Идентификатор администратора
        /// </summary>
        [Column("admin_id")]
        [ForeignKey("AdminId")]
        public Guid? AdminId { get; set; }

        /// <summary>
        /// Навигационное поле для Admin
        /// </summary>
        [NotMapped]
        public Admin Admin { get; set; }

    }
}
