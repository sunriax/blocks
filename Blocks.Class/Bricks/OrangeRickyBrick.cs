using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class OrangeRickyBrick<T> : BaseBrick<T>
    {
        public OrangeRickyBrick()
        {
            //         +---+
            //         |   |
            // +---+---+---+
            // |   |   |   |
            // +---+---+---+

            this.Brick = new bool[,]
            {
                { false, false, true },
                { true,  true,  true }
            };
        }
    }
}
