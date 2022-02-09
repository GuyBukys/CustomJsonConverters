using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;

namespace CustomJsonConverters.UnitTests;
public class ConvertersUnitTests
{
    [Fact]
    public void CanConvertStringToDateOnly()
    {
        DateOnly dateOnly = new(2021, 01, 02);

        JsonSerializerOptions jsonSerializerOptions = new();
        jsonSerializerOptions.Converters.Add(CustomJsonConverters.StringToDateOnlyConverter());

        string json = JsonSerializer.Serialize(dateOnly, jsonSerializerOptions);
        DateOnly objAfterDeserialize = JsonSerializer.Deserialize<DateOnly>(json, jsonSerializerOptions);

        Assert.NotEqual(default, objAfterDeserialize);
    }

    [Fact]
    public void CanConvertStringToTimeOnly()
    {
        TimeOnly timeOnly = new(4, 20, 0);

        JsonSerializerOptions jsonSerializerOptions = new();
        jsonSerializerOptions.Converters.Add(CustomJsonConverters.StringToTimeOnlyConverter());

        string json = JsonSerializer.Serialize(timeOnly, jsonSerializerOptions);
        TimeOnly objAfterDeserialize = JsonSerializer.Deserialize<TimeOnly>(json, jsonSerializerOptions);

        Assert.NotEqual(default, objAfterDeserialize);
    }
}