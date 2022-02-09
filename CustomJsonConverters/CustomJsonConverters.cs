using CustomJsonConverters.Converters;
using System.Text.Json.Serialization;

namespace CustomJsonConverters;

/// <summary>
/// static class for creating custom json converter objects.
/// </summary>
public static class CustomJsonConverters
{
    /// <summary>
    /// <see cref="string"/> to <see cref="DateOnly"/> converter.
    /// </summary>
    /// <returns>The custom <see cref="JsonConverter{DateOnly}"/> instance</returns>
    public static JsonConverter StringToDateOnlyConverter() => new StringToDateOnlyConverter();

    /// <summary>
    /// <see cref="string"/> to <see cref="DateOnly"/> converter.
    /// </summary>
    /// <param name="dateFormat">The date string format.</param>
    /// <returns>The custom <see cref="JsonConverter{DateOnly}"/> instance</returns>
    public static JsonConverter StringToDateOnlyConverter(string dateFormat) => new StringToDateOnlyConverter(dateFormat);

    /// <summary>
    /// <see cref="string"/> to <see cref="TimeOnly"/> converter.
    /// </summary>
    /// <returns>The custom <see cref="JsonConverter{TimeOnly}"/> instance</returns>
    public static JsonConverter StringToTimeOnlyConverter() => new StringToTimeOnlyConverter();

    /// <summary>
    /// <see cref="string"/> to <see cref="TimeOnly"/> converter.
    /// </summary>
    /// <param name="timeFormat">The time string format.</param>
    /// <returns>The custom <see cref="JsonConverter{TimeOnly}"/> instance</returns>
    public static JsonConverter StringToTimeOnlyConverter(string timeFormat) => new StringToTimeOnlyConverter(timeFormat);
}
