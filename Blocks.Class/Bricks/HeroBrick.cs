using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class HeroBrick : BaseBrick
    {
        public HeroBrick()
        {
            // +---+---+---+---+
            // |   |   |   |   |
            // +---+---+---+---+

            this.Appearance = new bool[,]
            {
                { true,  true, true, true }
            };
        }
    }
}
