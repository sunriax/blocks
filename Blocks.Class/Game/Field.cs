using Blocks.Class.Bricks;
using System.Collections.Generic;
using System.Drawing;

namespace Blocks.Class.Game
{
    public class Field<T>
    {
        List<FieldBrick<T>> elements = new List<FieldBrick<T>>();

        public Field() { }

        public FieldBrick<T> Current { get => this.elements.Count > 0 ? this.elements [this.elements.Count - 1] : null; }
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
