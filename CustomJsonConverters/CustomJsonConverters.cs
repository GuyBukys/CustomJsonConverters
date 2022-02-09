using CustomJsonConverters.Converters;
using System.Text.Json.Serialization;

namespace CustomJsonConverters;

public static class CustomJsonConverters
{
    public static JsonConverter StringToDateOnlyConverter()
    {
        return new StringToDateOnlyConverter();
    }

    public static JsonConverter StringToDateOnlyConverter(string dateFormat)
    {
        return new StringToDateOnlyConverter(dateFormat);
    }

    public static JsonConverter StringToTimeOnlyConverter()
    {
        return new StringToTimeOnlyConverter();
    }

    public static JsonConverter StringToTimeOnlyConverter(string timeFormat)
    {
        return new StringToTimeOnlyConverter(timeFormat);
    }
}
