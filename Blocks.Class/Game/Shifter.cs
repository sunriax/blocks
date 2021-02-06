using Blocks.Class.Bricks;
using Blocks.Class.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blocks.Class.Game
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
        private Validate<T> validate;

        public Shifter(Field<T> field)
        {
            this.field = field;
            this.validate = new Validate<T>(this.field)
            {
                Size = this.Size
            };
        }

        public FieldSize Size { get; set; }

        public bool Tick()
        {
            if (this.field.Current is null)
                return true;

            if ((this.field.Current.Position.Y + this.field.Current.Brick.Height) < this.Size.Height)
            {
                // Check if brick collides
                if (this.validate.Shift())
                    this.field.Current.Position.Y += 1;
                else
                    return true;
                return false;
            }
            return true;

            // Missing
            // Check if there are full rows
        }

        public void Rotate()
        {
            // Missing
            // Implement if Rotation is possible
            // Check if brick is outside field

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

        public void Move(Direction direction)
        {

            switch (direction)
            {
                case Direction.Left:
                    if (this.field.Current.Position.X <= 0 ||
                        !this.validate.Move(direction))
                        break;
                    this.field.Current.Position.X -= 1;
                    break;
                case Direction.Right:
                    if ((this.field.Current.Position.X + this.field.Current.Brick.Width) >= this.Size.Width || 
                         !this.validate.Move(direction))
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
