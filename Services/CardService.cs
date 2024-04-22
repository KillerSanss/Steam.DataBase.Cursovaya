using steam.Infrastructure.Context;
using steam.Infrastructure.Entities;

namespace steam.Services
{
    /// <summary>
    /// Сервис для Card
    /// </summary>
    public static class CardService
    {
        /// <summary>
        /// Создание карты
        /// </summary>
        /// <param name="cardNumber">Номер карты.</param>
        /// <param name="experationDate">Дата окончания действия карты.</param>
        /// <param name="nameOnCard">Имя на карте.</param>
        /// <param name="svv">Код на обратной стороне.</param>
        /// <param name="ballance">Баллансе на карте.</param>
        /// <param name="userId">Идентификатор пользователя.</param> 
        /// <returns>Карта.</returns>
        public static Card Create(
            string cardNumber,
            DateTime experationDate,
            string nameOnCard,
            string svv,
            double ballance,
            Guid userId)
        {
            return new Card
            {
                Number = cardNumber,
                ExperationDate = experationDate,
                NameOnCard = nameOnCard,
                CVV = svv,
                Ballance = ballance,
                UserId = userId
            };
        }

        /// <summary>
        /// Получение всех карт удовлетворяющих условию
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="minDate">Минимальная дата просрочки.</param>
        /// <param name="maxDate">Максимальная дата просрочки.</param>
        /// <param name="minBallance">Минимальный балланс на карте.</param>
        /// <param name="maxBallance">Максимальный балланс на карте.</param>
        /// <returns>Список карт.</returns>
        public static List<Card> GetAllWhere(
            SteamDbContext _dbContext,
            DateTime minDate,
            DateTime maxDate,
            double minBallance,
            double maxBallance)
        {
            List<Card> cards = new List<Card>();

            foreach (var card in _dbContext.Cards)
            {
                if (
                    card.ExperationDate >= minDate
                    && card.ExperationDate <= maxDate
                    && card.Ballance >= minBallance
                    && card.Ballance <= maxBallance)
                {
                    cards.Add(card);
                }
            }

            return cards;
        }

        /// <summary>
        /// Получение всех карт
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <returns>Список карт.</returns>
        public static List<Card> GetAll(SteamDbContext _dbContext)
        {
            List<Card> cards = new List<Card>();

            foreach (var card in _dbContext.Cards)
            {
                cards.Add(card);
            }

            return cards;
        }

        /// <summary>
        /// Получение карты по идентификатору
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="productId">Идентификатор карты.</param>
        /// <returns>тКарта.</returns>
        public static Card GetById(
            SteamDbContext _dbContext,
            Guid cardId)
        {
            var card = _dbContext.Cards.FirstOrDefault(c => c.Id == cardId);

            return card;
        }
    }
}
