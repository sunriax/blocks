using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Ragae.Game.Blocks.GameLib
{
    public class Field
    {
        public Field(Size size)
        {
            this.Size = size;
            this.Line = new List<Item[]>();
        }

        public FieldBrick Next { get; set; }
        public FieldBrick Current { get; set; }

        public List<Item[]> Line { get; set; }

        public Size Size { get; private set; }

        public IEnumerable<Item[]> FullLines() => this.Line.Where(x => x.All(x => x is not null));

        public bool MegaLine()
        {
            int line = 1;

            for (int y = 0; y < this.Line.Count; y++)
            {
                if (this.Line.ElementAt(y).All(x => x is not null))
                {
                    if (line++ == 4)
                        return true;
                }
                else
                {
                    line = 1;
                }
            }
            return false;
        }

        public bool Brick2Field()
        {
            if (this.Current is null)
                return false;

            for (int y = 0; y < this.Current.Brick.Apperance.GetLength(0); y++)
            {
                if (this.Line.ElementAtOrDefault((this.Current.Position.Y + y)) is null)
                {
                    this.Line.Add(new Item[(this.Size.Width)]);
                }

                for (int x = 0; x < this.Current.Brick.Apperance.GetLength(1); x++)
                {
                    if(this.Current.Brick.Apperance[this.Current.Brick.Apperance.GetLength(0) - y - 1, x])
                    {
                        int index_y = (this.Current.Position.Y + y);
                        int index_x = (this.Current.Position.X + x);

                        this.Line.ElementAt(index_y)[index_x] = new Item
                        {
                            Color = this.Current.Color
                        };
                    }
                }
            }
            return true;
        }
    }

    //    +---+---+---+---+---+---+---+---+
    // 10 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  9 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  8 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  7 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  6 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  5 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  4 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  3 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  2 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  1 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //  0 |   |   |   |   |   |   |   |   |
    //    +---+---+---+---+---+---+---+---+
    //      0   1   2   3   4   5   6   7

}
