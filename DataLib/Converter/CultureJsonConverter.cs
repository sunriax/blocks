using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RaGae.Game.Blocks.DataLib.Converter
{
    public class CultureJsonConverter : JsonConverter<CultureInfo>
    {
        public override CultureInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => new CultureInfo(reader.GetString());

        public override void Write(Utf8JsonWriter writer, CultureInfo value, JsonSerializerOptions options) => writer.WriteStringValue(value.Name);
    }
}
