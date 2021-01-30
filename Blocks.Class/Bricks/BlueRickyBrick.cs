using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class BlueRickyBrick<T> : BaseBrick<T>
    {
        public BlueRickyBrick()
        {
            // +---+
            // |   |
            // +---+---+---+
            // |   |   |   |
            // +---+---+---+

            this.Brick = new bool[,]
            {
                { true,  false, false },
                { true,  true,  true  }
            };
        }
    }
}
