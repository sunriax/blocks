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
        public static bool ValidateRotation<T>(this Field<T> field)
        {
            return false;
        }

        public static bool ValidateMove<T>(this Field<T> field, Direction direction)
        {
            foreach (FieldBrick<T> fieldBrick in field.Elements.Where(e => e.GetHashCode() != field.Current.GetHashCode()))
            {
                if (TouchPoints<T>.Touch(TouchPoints<T>.Points(field.Current.Brick, field.Current.Position),
                                         TouchPoints<T>.Points(fieldBrick.Brick, fieldBrick.Position), direction))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateShift<T>(this Field<T> field)
        {
            foreach (FieldBrick<T> fieldBrick in field.Elements.Where(e => e.GetHashCode() != field.Current.GetHashCode()))
            {
                if (TouchPoints<T>.Touch(TouchPoints<T>.Points(field.Current.Brick, field.Current.Position),
                                         TouchPoints<T>.Points(fieldBrick.Brick, fieldBrick.Position), Direction.Down))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
