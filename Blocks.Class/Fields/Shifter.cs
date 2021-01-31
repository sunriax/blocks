using Blocks.Class.Bricks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blocks.Class.Fields
{
    public enum Direction
    {
        Down,
        Left,
        Right
    }

    public class Shifter<T>
    {
        private Field<T> field;

        public Shifter(Field<T> field)
        {
            this.field = field;
        }

        public FieldSize Size { get; set; }

        public bool Tick()
        {
            //for (int x = 0; x < this.field.Current.Brick.Width; x++)
            //{
            //    foreach (FieldBrick<T> item in this.field.Elements)
            //    {

            //    }
            //}

            this.field.Current.Position.Y += 1;

            if ((this.field.Current.Position.Y + this.field.Current.Brick.Height) < (this.Size.Height - 1))
                return false;
            return true;
        }

        public void Shift(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    this.field.Current.Position.X -= 1;
                    break;
                case Direction.Right:
                    this.field.Current.Position.X += 1;
                    break;
                default:
                    this.Tick();
                    break;
            }
        }
    }
}
