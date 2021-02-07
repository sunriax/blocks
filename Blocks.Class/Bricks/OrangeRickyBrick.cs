using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class OrangeRickyBrick : BaseBrick
    {
        public OrangeRickyBrick()
        {
            //         +---+
            //         |   |
            // +---+---+---+
            // |   |   |   |
            // +---+---+---+

            this.Appearance = new bool[,]
            {
                { false, false, true },
                { true,  true,  true }
            };
        }
    }
}
