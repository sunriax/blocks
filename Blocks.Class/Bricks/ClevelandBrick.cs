using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Bricks
{
    public class ClevelandBrick<T> : BaseBrick<T>
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
