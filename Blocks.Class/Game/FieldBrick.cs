using Blocks.Class.Bricks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blocks.Class.Game
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
