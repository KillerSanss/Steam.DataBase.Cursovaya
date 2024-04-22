namespace steam.Validations.Errors
{
    /// <summary>
    /// Класс ошибок
    /// </summary>
    public abstract class ErrorMessages
    {
        /// <summary>
        /// Ошибка данных для входа
        /// </summary>
        public const string InvalidLoginOrPassword = "Неверный логин или пароль";

        /// <summary>
        /// Ошибка для никнейма
        /// </summary>
        public const string InvalidNickName = "Неверный формат никнейма";

        /// <summary>
        /// Ошибка для имени
        /// </summary>
        public const string InvalidName = "Неверный формат имени";

        /// <summary>
        /// Ошибка для пароля
        /// </summary>
        public const string InvalidPassword = "Неверный формат пароля";

        /// <summary>
        /// Ошибка для электронной почты
        /// </summary>
        public const string InvalidEmail = "Неверный формат электронной почты";

        /// <summary>
        /// Ошибка для номера телефона
        /// </summary>
        public const string InvalidPhone = "Неверный формат номера телефона";

        /// <summary>
        /// Ошибка для названи
        /// </summary>
        public const string InvalidTitle = "Неверный формат для названия";

        /// <summary>
        /// Ошибка для описания
        /// </summary>
        public const string InvalidDescription = "Неверный формат для описания";

        /// <summary>
        /// Ошибка для цены
        /// </summary>
        public const string InvalidPrice = "Неверный формат для цены";

        /// <summary>
        /// Ошибка для номера карты
        /// </summary>
        public const string InvalidCardNumber = "Неверный формат для номера карты";

        /// <summary>
        /// Ошибка для cvv
        /// </summary>
        public const string InvalidCvv = "Неверный формат для cvv";

        /// <summary>
        /// Ошибка для cvv
        /// </summary>
        public const string InvalidDate = "Неверный формат для даты";

        /// <summary>
        /// Сообщение об исключении null
        /// </summary>
        /// <remarks>
        /// Использовать вместе со string.Format
        /// {0} - имя свойства
        /// </remarks>
        public const string NullError = "{0} is null"; 
    }
}
