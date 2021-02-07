using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class TeeweeBrick : BaseBrick
    {
        public TeeweeBrick()
        {
            //     +---+
            //     |   |
            // +---+---+---+
            // |   |   |   |
            // +---+---+---+

            this.Appearance = new bool[,]
            {
                { false,  true,  false },
                { true,   true,  true  }
            };
        }
    }
}
