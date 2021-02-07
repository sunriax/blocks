using Blocks.Class.Bricks;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blocks.Class.Functions
{
    public static class Validate
    {
        public static bool ValidateRotation(this Field field)
        {


            return true;
        }

        public static bool ValidateMove(this Field field, Direction direction)
        {
            foreach (FieldBrick fieldBrick in field.Elements.Where(e => e.GetHashCode() != field.Current.GetHashCode()))
            {
                if (TouchPoints.Touch(TouchPoints.Points(field.Current.Brick, field.Current.Position),
                                         TouchPoints.Points(fieldBrick.Brick, fieldBrick.Position), direction))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateShift(this Field field)
        {
            foreach (FieldBrick fieldBrick in field.Elements.Where(e => e.GetHashCode() != field.Current.GetHashCode()))
            {
                if (TouchPoints.Touch(TouchPoints.Points(field.Current.Brick, field.Current.Position),
                                         TouchPoints.Points(fieldBrick.Brick, fieldBrick.Position), Direction.Down))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
