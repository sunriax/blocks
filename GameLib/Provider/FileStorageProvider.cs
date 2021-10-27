using Ragae.Game.Blocks.DataLib;
using Ragae.Game.Blocks.DataLib.Converter;
using System;
using System.IO;
using System.Text.Json;

namespace Ragae.Game.Blocks.GameLib.Provider
{
    public class FileStorageProvider : StorageProvider
    {
        public FileStorageProvider(string fileName = null)
        {
            this.FileName = fileName;

            if (!Directory.Exists(TempPath))
                Directory.CreateDirectory(TempPath);
        }

        public string FileName { get; private set; }

        public static string TempPath { get; private set; } = Path.Combine(Path.GetTempPath(), nameof(Blocks));

        public override bool Load(Manager manager)
        {
            if (!File.Exists(Path.Combine(TempPath, FileName)))
                return false;

            GameData data = DataService.Read<GameData>(
                Path.Combine(TempPath, FileName),
                new JsonSerializerOptions()
                {
                    Converters =
                            {
                                new ColorJsonConverter(),
                                new BrickJsonConverter()
                            }
                });

            if (data is null || !ValidateChecksum(data))
                return false;

            manager.Load(data.Field, data.Level, data.Score);
            return true;
        }

        public override bool Save(Manager manager)
        {
            if (string.IsNullOrWhiteSpace(this.FileName))
                this.FileName = $"{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.sav";

            GameData data = new GameData()
            {
                Score = manager.Score,
                Level = manager.Level,
                Field = manager.Field
            };

            data.Checksum = CreateChecksum(data);

            return DataService.Write(
                Path.Combine(TempPath, this.FileName),
                data,
                new JsonSerializerOptions()
                {
                    Converters =
                    {
                        new ColorJsonConverter(),
                        new BrickJsonConverter()
                    }
                });
        }

        public override string ToString() => Path.Combine(TempPath, this.FileName);
    }
}
