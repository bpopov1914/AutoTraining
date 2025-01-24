using Newtonsoft.Json;

namespace L14Homework.T5Class;

public class DateTimeConverter : JsonConverter<DateTime>
{
    private const string DateFormat = "yyyy-MM-dd";

    public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString(DateFormat));
    }

    public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        string dateString = reader.Value.ToString();
        return DateTime.ParseExact(dateString, DateFormat, null);
    }
}