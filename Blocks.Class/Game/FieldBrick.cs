using Blocks.Class.Bricks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Game
{
    public class FieldBrick<T>
    {
        public FieldBrick(BaseBrick<T> brick)
        {
            this.Brick = brick;
        }

        public BaseBrick<T> Brick { get; private set; }
        public Point Position { get; set; }
    }
}
