using Ragae.Game.Blocks.BrickLib;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ragae.Game.Blocks.DataLib.Converter
{
    public class BrickJsonConverter : JsonConverter<BaseBrick>
    {
        public override BaseBrick Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => BrickFactory.CreateBrick(reader.GetString());

        public override void Write(Utf8JsonWriter writer, BaseBrick value, JsonSerializerOptions options) => writer.WriteStringValue(value.GetType().Name);
    }
}
