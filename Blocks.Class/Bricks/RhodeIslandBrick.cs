using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class RhodeIslandBrick<T> : BaseBrick<T>
    {
        public RhodeIslandBrick()
        {
            //     +---+---+
            //     |   |   |
            // +---+---+---+
            // |   |   |
            // +---+---+

            this.Appearance = new bool[,]
            {
                { true,  true,  false },
                { false,  true,  true  }
            };
        }
    }
}
