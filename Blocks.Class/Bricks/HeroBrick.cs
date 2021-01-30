using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class HeroBrick<T> : BaseBrick<T>
    {
        public HeroBrick()
        {
            // +---+---+---+---+
            // |   |   |   |   |
            // +---+---+---+---+

            this.Brick = new bool[,]
            {
                { true,  true, true, true }
            };
        }
    }
}
