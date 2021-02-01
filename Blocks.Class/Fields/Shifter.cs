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
            if (this.field.Current is null)
                return true;

            // Missing
            // Check if brick collides
            // Check if there are full rows

            if ((this.field.Current.Position.Y + this.field.Current.Brick.Height) < this.Size.Height)
            {
                this.field.Current.Position.Y += 1;
                return false;
            }

            

            return true;
        }

        public void Rotate()
        {
            // Missing
            // Implement if Rotation is possible

            switch (this.field.Current.Brick.Position)
            {
                case Position.Right:
                    this.field.Current.Brick.Rotate(Position.Down);
                    break;
                case Position.Down:
                    this.field.Current.Brick.Rotate(Position.Left);
                    break;
                case Position.Left:
                    this.field.Current.Brick.Rotate(Position.Up);
                    break;
                default:
                    this.field.Current.Brick.Rotate(Position.Right);
                    break;
            }
        }

        public void Shift(Direction direction)
        {

            switch (direction)
            {
                case Direction.Left:
                    if (this.field.Current.Position.X <= 0)
                        break;
                    this.field.Current.Position.X -= 1;
                    break;
                case Direction.Right:
                    if ((this.field.Current.Position.X + this.field.Current.Brick.Width) >= this.Size.Width)
                        break;
                    this.field.Current.Position.X += 1;
                    break;
                default:
                    this.Tick();
                    break;
            }
        }
    }
}
