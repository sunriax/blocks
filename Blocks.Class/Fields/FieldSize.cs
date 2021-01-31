using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Fields
{
    public class FieldSize
    {
        public FieldSize() { }

        public FieldSize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
