using System.Text.RegularExpressions;

namespace steam.Validations
{
    /// <summary>
    /// Класс для описания регулярных выражений
    /// </summary>
    public static class RegularExpresions
    {
        /// <summary>
        /// Регулярное выражение для телефона
        /// </summary>
        public static readonly Regex PhonePattern = new Regex("^373\\d{8}$");

        /// <summary>
        /// Регулярное выражение для строк
        /// </summary>
        public static readonly Regex SymbolsPattern = new Regex("^.{1,60}$");

        /// <summary>
        /// Регулярное выражение для имени
        /// </summary>
        public static readonly Regex OnlyLettersPattern = new Regex("^[a-zA-Z]{1,25}$");

        /// <summary>
        /// Регулярное выражение для электронной почты
        /// </summary>
        public static readonly Regex EmailPattern = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");

        /// <summary>
        /// Регулярное выражение для пароля
        /// </summary>
        public static readonly Regex PasswordPattern = new Regex("^(?=.*[a-zA-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$");

        /// <summary>
        /// Регулярное выражение для cvv
        /// </summary>
        public static readonly Regex CvvPattern = new Regex("^\\d{3}$");

        /// <summary>
        /// Регулярное выражение для номера карты
        /// </summary>
        public static readonly Regex CardNumberPattern = new Regex("^\\d{4}-\\d{4}-\\d{4}-\\d{4}$");
    }
}
