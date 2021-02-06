using Blocks.Class.Bricks;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blocks.Class.Functions
{
    public class Validate<T>
    {
        private Field<T> field;

        public Validate(Field<T> field)
        {
            this.field = field;
        }

        public bool Rotation()
        {

            return false;
        }

        public bool Move()
        {

            return false;
        }

        public bool Shift()
        {

            return false;
        }
    }
}
