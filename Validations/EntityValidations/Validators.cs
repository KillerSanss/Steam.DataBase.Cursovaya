using steam.Validations.Errors;
using System.Text.RegularExpressions;

namespace steam.Validations.EntityValidaitons;

/// <summary>
/// Валидация для телеграмма
/// </summary>
public static class Validators
{
    /// <summary>
    /// Метод валидации
    /// </summary>
    /// <param name="value">Объект валидации.</param>
    /// <param name="paramName">Название параметра.</param>
    /// <param name="regex">Регулярнре выражение.</param>
    /// <param name="message">Сообщение об ошибке.</param>
    /// <returns>Сообщение об ошибке или пустая строка.</returns>
    public static string ValidateString(string value, string paramName, Regex regex, string message) 
    {
        if (value == null)
        {
            return string.Format(ErrorMessages.NullError, paramName);
        }
        if (!regex.IsMatch(value))
        {
            return message;
        }
        return string.Empty;
    }

    /// <summary>
    /// Валидация чисел с плавающей точкой
    /// </summary>
    /// <param name="value">Объект валидации.</param>
    /// <param name="paramName">Название параметра.</param>
    /// <param name="message">Сообщение об ошибке.</param>
    /// <returns>Сообщение об ошибке или пустая строка.</returns>
    public static string ValidateDouble(double value, string paramName, string message)
    {
        if (value == null)
        {
            return string.Format(ErrorMessages.NullError, paramName);
        }
        if (value < 0)
        {
            return message;
        }
        return string.Empty;
    }

    /// <summary>
    /// Валидация даты
    /// </summary>
    /// <param name="value">Объект валидации.</param>
    /// <param name="paramName">Название параметра.</param>
    /// <param name="message">Сообщение об ошибке.</param>
    /// <returns>Сообщение об ошибке или пустая строка.</returns>
    public static string ValidateDate(DateTime value, string paramName, string message)
    {
        if (value == default)
        {
            return string.Format(ErrorMessages.NullError, paramName);
        }
        if (value < DateTime.Now)
        {
            return message;
        }
        return string.Empty;
    }
}
