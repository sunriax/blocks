using RaGae.Game.Blocks.BrickLib;
using System.Drawing;

namespace RaGae.Game.Blocks.GameLib
{
    public class FieldBrick
    {
        public FieldBrick(BaseBrick brick)
        {
            this.Brick = brick;
        }

        public BaseBrick Brick { get; private set; }
        public Point Position { get; set; }
        public Color Color { get; set; }
    }
}
