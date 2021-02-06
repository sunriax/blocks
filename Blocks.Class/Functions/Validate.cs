using Blocks.Class.Bricks;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public FieldSize Size { get; set; }

        public bool Rotation()
        {

            return false;
        }

        public bool Move(Direction direction)
        {
            foreach (FieldBrick<T> fieldBrick in this.field.Elements.Where(e => e.GetHashCode() != this.field.Current.GetHashCode()))
            {
                if (TouchPoints<T>.Touch(TouchPoints<T>.Points(this.field.Current.Brick, this.field.Current.Position),
                                         TouchPoints<T>.Points(fieldBrick.Brick, fieldBrick.Position), direction))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Shift()
        {
            foreach (FieldBrick<T> fieldBrick in this.field.Elements.Where(e => e.GetHashCode() != this.field.Current.GetHashCode()))
            {
                if (TouchPoints<T>.Touch(TouchPoints<T>.Points(this.field.Current.Brick, this.field.Current.Position),
                                         TouchPoints<T>.Points(fieldBrick.Brick, fieldBrick.Position), Direction.Down))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
