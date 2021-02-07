using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class ClevelandBrick : BaseBrick
    {
        public ClevelandBrick()
        {
            // +---+---+
            // |   |   |
            // +---+---+---+
            //     |   |   |
            //     +---+---+

            this.Appearance = new bool[,]
            {
                { true,  true,  false },
                { false,  true,  true  }
            };
        }
    }
}
