using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Ragae.Game.Blocks.AppLib
{
    public class ScoreBoard
    {
        public List<ScoreEntry> Entries { get; set; }

        public static string CreateChecksum(ScoreEntry board)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return BitConverter.ToString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes($"{board.Name}-{board.Score}"))).Replace("-", String.Empty);
            }
        }

        public static bool ValidateChecksum(ScoreEntry board) => CreateChecksum(board) == board.Checksum ? true : false;

        public void Clear() => this.Entries.Clear();
    }
}
