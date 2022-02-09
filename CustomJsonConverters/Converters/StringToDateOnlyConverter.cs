using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomJsonConverters.Converters;

public class StringToDateOnlyConverter : JsonConverter<DateOnly>
{
    private readonly string _dateFormat;

    public StringToDateOnlyConverter()
    {
        _dateFormat = "dd/MM/yyyy";
    }

    public StringToDateOnlyConverter(string dateFormat)
    {
        _dateFormat = dateFormat;
    }

    public override DateOnly Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        bool canParse = DateOnly.TryParseExact(reader.GetString(), _dateFormat, out DateOnly dateOnly);
        return canParse ? dateOnly : default;
    }

    public override void Write(
        Utf8JsonWriter writer,
        DateOnly value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_dateFormat));
    }
}
