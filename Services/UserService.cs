using steam.Infrastructure.Context;
using steam.Infrastructure.Entities;
using steam.Infrastructure.Enums;

namespace steam
{
    /// <summary>
    /// Сервис для User
    /// </summary>
    public static class UserService
    {
        /// <summary>
        /// Создание пользователя
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="nickName">Никнейм.</param>
        /// <param name="password">Пароль.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="role">Роль.</param>
        /// <param name="registrationDate">Дата регистрации.</param>
        /// <param name="ballance">Балланс средств.</param>
        /// <returns>Пользователь.</returns>
        public static User Create(
            string name,
            string nickName,
            string password,
            string email,
            string phone,
            Role role,
            DateTime registrationDate,
            double ballance)
        {
            return new User
            {
                Name = name,
                NickName = nickName,
                Password = password,
                Email = email,
                Phone = phone,
                Role = role,
                RegistrationDate = registrationDate,
                Ballance = ballance,
            };
        }

        /// <summary>
        /// Обновление пользователя.
        /// </summary>
        /// <param name="user">Пользователь для обновления.</param>
        /// <param name="name">Имя.</param>
        /// <param name="nickName">Никнейм.</param>
        /// <param name="password">Пароль.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <returns>Обновленный пользователь.</returns>
        public static User Update(User user,
            string name,
            string nickName,
            string password,
            string email,
            string phone,
            double ballance,
            Guid? cardId)
        {
            user.Name = name;
            user.NickName = nickName;
            user.Password = password;
            user.Email = email;
            user.Phone = phone;
            user.Ballance = ballance;
            if (cardId != null)
            {
                user.CardId = cardId;
            }

            return user;
        }

        /// <summary>
        /// Получение всех пользователей из базы данных
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <returns>Список пользователей.</returns>
        public static List<User> GetAll(
            SteamDbContext _dbContext)
        {
            List<User> users = new List<User>();

            foreach (var user in _dbContext.Users)
            {
                users.Add(user);
            }

            return users;
        }

        /// <summary>
        /// Получение всех пользователей удовлетворяющих условию
        /// </summary>
        /// <param name="_dbContext">Контекст базы данных.</param>
        /// <param name="minDate">Минимальная дата регистрации.</param>
        /// <param name="maxDate">Максимальная дата регистрации.</param>
        /// <param name="minBallance">Минимальный балланс на счету.</param>
        /// <param name="maxBallance">Максимальный балланс на счету.</param>
        /// <param name="role">Ротль пользователя.</param>
        /// <returns>Список пользователей.</returns>
        public static List<User> GetAllWhere(
            SteamDbContext _dbContext,
            DateTime minDate,
            DateTime maxDate,
            double minBallance,
            double maxBallance,
            Role role)
        {
            List<User> users = new List<User>();

            foreach (var user in _dbContext.Users)
            {
                if (
                    user.RegistrationDate >= minDate
                    && user.RegistrationDate <= maxDate
                    && user.Ballance >= minBallance
                    && user.Ballance <= maxBallance
                    && user.Role == role)
                {
                    users.Add(user);
                }
            }

            return users;
        }
    }
}
