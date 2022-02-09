using System.Text.Json.Serialization;

namespace CustomJsonConverters;

public static class CustomJsonConverters
{
    public static JsonConverter CreateConverter<T>()
        where T : JsonConverter
    {
    }
}