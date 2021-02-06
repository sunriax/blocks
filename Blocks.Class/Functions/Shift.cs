using Blocks.Class.Bricks;
using Blocks.Class.Functions;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Blocks.Class.Functions
{
    public enum Direction
    {
        Down,
        Left,
        Right
    }

    public static class Shift
    {
        public static bool Tick<T>(this Field<T> field)
        {
            if (field.Current is null)
                return true;

            if ((field.Current.Position.Y + field.Current.Brick.Height) < field.Size.Height)
            {
                // Check if brick collides
                if (field.ValidateShift())
                    field.Current.Position.Y += 1;
                else
                    return true;
                return false;
            }
            return true;

            // Missing
            // Check if there are full rows
        }

        public static void Rotate<T>(this Field<T> field)
        {
            // Missing
            // Implement if Rotation is possible
            // Check if brick is outside field

            switch (field.Current.Brick.Position)
            {
                case Position.Right:
                    field.Current.Brick.Rotate(Position.Down);
                    break;
                case Position.Down:
                    field.Current.Brick.Rotate(Position.Left);
                    break;
                case Position.Left:
                    field.Current.Brick.Rotate(Position.Up);
                    break;
                default:
                    field.Current.Brick.Rotate(Position.Right);
                    break;
            }
        }

        public static void Move<T>(this Field<T> field, Direction direction)
        {

            switch (direction)
            {
                case Direction.Left:
                    if (field.Current.Position.X <= 0 ||
                        !field.ValidateMove(direction))
                        break;
                    field.Current.Position.X -= 1;
                    break;
                case Direction.Right:
                    if ((field.Current.Position.X + field.Current.Brick.Width) >= field.Size.Width || 
                         !field.ValidateMove(direction))
                        break;
                    field.Current.Position.X += 1;
                    break;
                default:
                    field.Tick();
                    break;
            }
        }
    }
}
