using steam.Infrastructure.Context;
using steam.Infrastructure.Entities;
using steam.Infrastructure.Enums;

namespace steam.Services
{
    /// <summary>
    /// Сервис для Question
    /// </summary>
    public static class QuestionService
    {
        /// <summary>
        /// Создание вопроса
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="description">Описание.</param>
        /// <param name="creationDate">Дата создания.</param>
        /// <param name="status">Статус вопроса.</param>
        /// <param name="userid">Идентификатор пользователя.</param>
        /// <returns>Вопрос.</returns>
        public static Question Create(
            string title,
            string description,
            DateTime creationDate,
            Status status,
            Guid userid)
        {
            return new Question
            {
                Title = title,
                Description = description,
                CreationDate = creationDate,
                Status = status,
                UserId = userid
            };
        }

        /// <summary>
        /// Получение всех вопросов
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <returns>Список вопросов.</returns>
        public static List<Question> GetAll(SteamDbContext _dbContext)
        {
            List<Question> questions = new List<Question>();

            foreach (var question in _dbContext.Questions)
            {
                questions.Add(question);
            }

            return questions;
        }

        /// <summary>
        /// Получение всех вопросов удовлетворяющих условию
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="status">Статус вопроса.</param>
        /// <param name="minDate">Минимальная дата создания.</param>
        /// <param name="maxDate">Максимальная дата создания.</param>
        /// <returns>Список вопросов.</returns>
        public static List<Question> GetAllWhere(
            SteamDbContext _dbContext,
            Status status,
            DateTime minDate,
            DateTime maxDate)
        {
            List<Question> questions = new List<Question>();

            foreach (var question in _dbContext.Questions)
            {
                if (question.Status == status 
                    && question.CreationDate >= minDate
                    && question.CreationDate <= maxDate)
                {
                    questions.Add(question);
                }
            }

            return questions;
        }

        /// <summary>
        /// Получение вопроса по идентификатору
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="questionId">Идентификатор вопроса.</param>
        /// <returns>Вопрос.</returns>
        public static Question GetById(
            SteamDbContext _dbContext,
            Guid questionId)
        {
            var question = _dbContext.Questions.FirstOrDefault(q => q.Id == questionId);

            return question;
        }

        /// <summary>
        /// Обновление вопроса (ответ)
        /// </summary>
        /// <param name="question">Вопрос для ответа.</param>
        /// <param name="answer">Ответ на вопрос.</param>
        /// <param name="adminId">Идентификатор администратора.</param>
        /// <returns>Вопрос.</returns>
        public static Question Update(
            Question question,
            string answer,
            Guid adminId)
        {
            question.Answer = answer;
            question.Status = Status.Resolved;
            question.AdminId = adminId;

            return question;
        }
    }
}
