using Blocks.Class.Bricks;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blocks.Class.Functions
{
    public class Collect<T>
    {
        private Field<T> field;

        public Collect(Field<T> field)
        {
            this.field = field;
        }

        public bool Complete()
        {

            return false;
        }
    }
}
