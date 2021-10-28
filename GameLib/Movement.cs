using Ragae.Game.Blocks.BrickLib.Enumeration;
using Ragae.Game.Blocks.GameLib.Enumeration;
using System.Drawing;
using System.Linq;

namespace Ragae.Game.Blocks.GameLib
{
    public delegate void Invalidate(object sender);
    public class Movement
    {
        public event Invalidate Update;

        public Movement(Field field) => this.Field = field;

        public Field Field { get; set; }

        public bool Down()
        {
            if (this.Field.Current.Position.Y <= 0)
                return false;

            for (int y = 0; y < this.Field.Current.Brick.Apperance.GetLength(0); y++)
            {
                for (int x = 0; x < this.Field.Current.Brick.Apperance.GetLength(1); x++)
                {
                    if(this.Field.Current.Brick.Apperance[(this.Field.Current.Brick.Apperance.GetLength(0) - 1 - y),x])
                    {
                        if(this.Field.Line.ElementAtOrDefault((this.Field.Current.Position.Y - 1 + y)) is not null)
                        {
                            if(this.Field.Line.ElementAt(this.Field.Current.Position.Y - 1 + y)[this.Field.Current.Position.X + x] is not null)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            this.Field.Current.Position = new Point(this.Field.Current.Position.X, this.Field.Current.Position.Y - 1);

            this.Update?.Invoke(this);
            return true;
        }

        public bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    if (this.Field.Current.Position.X <= 0)
                        return false;

                    for (int y = 0; y < this.Field.Current.Brick.Apperance.GetLength(0); y++)
                    {
                        for (int x = 0; x < this.Field.Current.Brick.Apperance.GetLength(1); x++)
                        {
                            if (this.Field.Current.Brick.Apperance[(this.Field.Current.Brick.Apperance.GetLength(0) - 1 - y), x])
                            {
                                if (this.Field.Line.ElementAtOrDefault((this.Field.Current.Position.Y + y)) is not null &&
                                    this.Field.Line.ElementAtOrDefault((this.Field.Current.Position.Y + y))[(this.Field.Current.Position.X - 1 + x)] is not null)
                                {
                                    return false;
                                }
                            }
                        }
                    }

                    this.Field.Current.Position = new Point(this.Field.Current.Position.X - 1, this.Field.Current.Position.Y);
                    break;
                case Direction.Right:
                    if (this.Field.Current.Position.X >= (this.Field.Size.Width - this.Field.Current.Brick.Apperance.GetLength(1)))
                        return false;

                    for (int y = 0; y < this.Field.Current.Brick.Apperance.GetLength(0); y++)
                    {
                        for (int x = 0; x < this.Field.Current.Brick.Apperance.GetLength(1); x++)
                        {
                            if (this.Field.Current.Brick.Apperance[(this.Field.Current.Brick.Apperance.GetLength(0) - 1 - y), (this.Field.Current.Brick.Apperance.GetLength(1) - 1 - x)])
                            {
                                if (this.Field.Line.ElementAtOrDefault((this.Field.Current.Position.Y + y)) is not null &&
                                    this.Field.Line.ElementAtOrDefault((this.Field.Current.Position.Y + y))[(this.Field.Current.Position.X + this.Field.Current.Brick.Apperance.GetLength(1) - x)] is not null)
                                {
                                    return false;
                                }
                            }
                        }
                    }

                    this.Field.Current.Position = new Point(this.Field.Current.Position.X + 1, this.Field.Current.Position.Y);
                    break;
            }
            this.Update?.Invoke(this);
            return true;
        }

        public bool Rotate(Rotation rotation)
        {
            if (((this.Field.Current.Brick.Apperance.GetLength(0) + this.Field.Current.Position.X - 1) >= this.Field.Size.Width) ||
                ((this.Field.Current.Brick.Apperance.GetLength(1) + this.Field.Current.Position.X - 1) >= this.Field.Size.Width))
                return false;


            for (int y = 0; y < this.Field.Current.Brick.Apperance.GetLength(1); y++)
            {
                for (int x = 0; x < this.Field.Current.Brick.Apperance.GetLength(0); x++)
                {
                    if (this.Field.Line.ElementAtOrDefault(this.Field.Current.Position.Y + y) is not null)
                    {
                        if (this.Field.Line.ElementAt(this.Field.Current.Position.Y + y)[this.Field.Current.Position.X + x] is not null)
                        {
                            switch (rotation)
                            {
                                case Rotation.Right:
                                    if (this.Field.Current.Brick.Apperance[(this.Field.Current.Brick.Apperance.GetLength(0) - 1 - x), (this.Field.Current.Brick.Apperance.GetLength(1) - 1 - y)])
                                    {
                                        return false;
                                    }
                                    break;
                                case Rotation.Left:
                                    if (this.Field.Current.Brick.Apperance[x, y])
                                    {
                                        return false;
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                    }
                }
            }

            this.Field.Current.Brick.Rotate(rotation);
            this.Update?.Invoke(this);
            return true;
        }
    }
}
