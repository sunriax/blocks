using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class TeeweeBrick<T> : BaseBrick<T>
    {
        public TeeweeBrick()
        {
            //     +---+
            //     |   |
            // +---+---+---+
            // |   |   |   |
            // +---+---+---+

            this.Brick = new bool[,]
            {
                { false,  true,  false },
                { true,   true,  true  }
            };
        }
    }
}
