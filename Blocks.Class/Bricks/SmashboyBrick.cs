using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class SmashboyBrick<T> : BaseBrick<T>
    {
        public SmashboyBrick()
        {
            // +---+---+
            // |   |   |
            // +---+---+
            // |   |   |
            // +---+---+

            this.Appearance = new bool[,]
            {
                { true,  true },
                { true,  true }
            };
        }
    }
}
