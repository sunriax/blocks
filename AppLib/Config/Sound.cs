using System;
using System.IO;

namespace Ragae.Game.Blocks.AppLib
{
    public class Sound
    {
        private string folder = "Sounds";

        public string Folder
        {
            get => this.folder;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    return;

                if (!Path.IsPathFullyQualified(value))
                {
                    this.folder = Path.Combine(Directory.GetCurrentDirectory(), value);
                    return;
                }
                this.folder = value;
            }
        }
        public string Game { get; set; } = "blocks.wav";
        public string MultiRow { get; set; } = "multirow.wav";
        public string Pause { get; set; } = "pause.wav";
        public string GameOver { get; set; } = "gameover.wav";
    }
}
