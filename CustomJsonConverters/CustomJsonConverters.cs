using CustomJsonConverters.Converters;
using System.Text.Json.Serialization;

namespace CustomJsonConverters;

public static class CustomJsonConverters
{
    public static JsonConverter StringToDateOnlyConverter() => new StringToDateOnlyConverter();

    public static JsonConverter StringToDateOnlyConverter(string dateFormat) => new StringToDateOnlyConverter(dateFormat);

    public static JsonConverter StringToTimeOnlyConverter() => new StringToTimeOnlyConverter();

    public static JsonConverter StringToTimeOnlyConverter(string timeFormat) => new StringToTimeOnlyConverter(timeFormat);
}
