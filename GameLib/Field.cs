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
        public int Width => this.Size.Width;
        public int Height => this.Size.Height;

        public IEnumerable<Item[]> FullLines()
        {
            List<Item[]> temp = new();

            for (int i = 0; i < this.Line.Count; i++)
            {
                if (this.Line.ElementAt(i).All(x => x is not null))
                {
                    temp.Add(this.Line.ElementAt(i));
                }
            }

            return temp;
        }

        public bool MegaLine()
        {
            int y_last = 0;

            for (int y = 1; y <= this.Line.Count; y++)
            {
                if (this.Line.ElementAt((y - 1)).All(x => x is not null))
                {
                    if((y - 1) == y_last)
                    {
                        y_last++;
                    }
                    else
                    {
                        y_last = 0;
                    }
                }
            }
            return y_last == 4 ? true : false;
        }

        public void Brick2Field()
        {
            for (int y = 0; y < this.Current.Brick.Apperance.GetLength(0); y++)
            {
                if (this.Line.ElementAtOrDefault((this.Current.Position.Y + y)) is null)
                {
                    this.Line.Add(new Item[(this.Width)]);
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
