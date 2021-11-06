using System;

namespace RaGae.Game.Blocks.LineLib
{
    public class Menu
    {
        public ConsoleKey Key { get; set; }
        public string Description { get; set; }

        public override string ToString() => string.IsNullOrWhiteSpace(this.Description) ? this.Key.ToString() : $"{this.Key} - {this.Description}";
    }
}
