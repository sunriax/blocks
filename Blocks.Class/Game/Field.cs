using Blocks.Class.Bricks;
using Blocks.Class.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Blocks.Class.Game
{
    public class Field
    {
        public const int MIN_WIDTH = 10;
        public const int MIN_HEIGHT = 10;

        List<FieldBrick> elements = new List<FieldBrick>();

        private FieldSize size;

        public Field() { }

        public Field(int width, int height)
        {
            this.Size = new FieldSize
            {
                Width = width,
                Height = height
            };
        }

        public FieldSize Size
        {
            get => this.size;
            set
            {
                if (value.Width < MIN_WIDTH || value.Height < MIN_HEIGHT)
                    throw new ArgumentOutOfRangeException($"{nameof(Size)}:{nameof(MIN_WIDTH)}/{nameof(MIN_HEIGHT)}");

                this.size = value;
            }
        }

        public FieldBrick Current { get => this.elements.Count > 0 ? this.elements[this.elements.Count - 1] : null; }
        public FieldBrick Next { get; set; }
        public List<FieldBrick> Elements { get => this.elements; }

        public void Add(List<Color> color)
        {
            this.CreateBrick(color);
        }

        public void Clear()
        {
            this.elements = new List<FieldBrick>();
        }
    }
}
