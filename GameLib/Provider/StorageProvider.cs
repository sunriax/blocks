using System;
using System.Security.Cryptography;
using System.Text;

namespace RaGae.Game.Blocks.GameLib.Provider
{
    public abstract class StorageProvider
    {
        protected class GameData
        {
            public int Score { get; set; }
            public int Level { get; set; }
            public Field Field { get; set; }
            public string Checksum { get; set; }
        }

        protected static string CreateChecksum(GameData gameData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return BitConverter.ToString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes($"{gameData.Field.Line.Count}-{gameData.Score}-{gameData.Level}"))).Replace("-", String.Empty);
            }
        }

        protected static bool ValidateChecksum(GameData gameData) => CreateChecksum(gameData) == gameData.Checksum ? true : false;

        public abstract bool Save(Manager manager);
        public abstract bool Load(Manager manager);
    }
}
