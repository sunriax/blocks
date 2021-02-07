using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class BlueRickyBrick : BaseBrick
    {
        public BlueRickyBrick()
        {
            // +---+
            // |   |
            // +---+---+---+
            // |   |   |   |
            // +---+---+---+

            this.Appearance = new bool[,]
            {
                { true,  false, false },
                { true,  true,  true  }
            };
        }
    }
}
