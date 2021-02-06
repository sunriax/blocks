using Blocks.Class.Bricks;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Blocks.Class.Game
{
    public class Field<T>
    {
        public const int MIN_WIDTH = 10;
        public const int MIN_HEIGHT = 10;

        List<FieldBrick<T>> elements = new List<FieldBrick<T>>();

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

        public FieldBrick<T> Current { get => this.elements.Count > 0 ? this.elements[this.elements.Count - 1] : null; }
        public List<FieldBrick<T>> Elements { get => this.elements; }

        public void Add(BaseBrick<T> brick)
        {
            this.elements.Add(new FieldBrick<T>(brick)
            {
                Position = new Point(0, -3)
            });
        }

        public void Clear()
        {
            this.elements = new List<FieldBrick<T>>();
        }
    }
}
