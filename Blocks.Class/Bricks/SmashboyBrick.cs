using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class SmashboyBrick : BaseBrick
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
