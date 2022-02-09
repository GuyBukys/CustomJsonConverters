using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomJsonConverters.Converters;

public class StringToTimeOnlyConverter : JsonConverter<TimeOnly>
{
    private readonly string _timeFormat;

    public StringToTimeOnlyConverter()
    {
        _timeFormat = "HH:mm:ss";
    }

    public StringToTimeOnlyConverter(string timeFormat)
    {
        _timeFormat = timeFormat;
    }

    public override TimeOnly Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        bool canParse = TimeOnly.TryParseExact(reader.GetString(), _timeFormat, out TimeOnly timeOnly);
        return canParse ? timeOnly : default;
    }

    public override void Write(
        Utf8JsonWriter writer,
        TimeOnly value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_timeFormat));
    }
}
