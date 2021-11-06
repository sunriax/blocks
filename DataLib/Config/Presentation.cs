using System.Collections.Generic;
using System.Drawing;

namespace RaGae.Game.Blocks.DataLib.Config
{
    public class Presentation
    {
        public Color Grid { get; set; } = Color.LightGray;

        public Color Background { get; set; } = Color.White;

        public List<Color> Blocks { get; set; } = new()
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Violet
        };
    }
}
