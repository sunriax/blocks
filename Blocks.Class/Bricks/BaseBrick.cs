using System;

namespace Blocks.Class.Bricks
{
    public enum Position
    {
        Up,
        Down,
        Right,
        Left
    }

    public abstract class BaseBrick<T>
    {
        private bool[,] brick =
            {
                { false, true,  false, false },
                { true,  true,  true,  true  },
                { false, true,  false, false }
            };

        public BaseBrick() { }

        public bool[,] Brick
        {
            get
            {
                bool[,] brick;

                switch (this.Position)
                {
                    case Position.Up:
                        return this.brick;
                    case Position.Down:
                        brick = new bool[this.brick.GetLength(0), this.brick.GetLength(1)];

                        for (int y = 0; y < this.brick.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.brick.GetLength(1); x++)
                            {
                                brick[y, x] = this.brick[(this.brick.GetLength(0) - y - 1), (this.brick.GetLength(1) - x - 1)];
                            }
                        }
                        return brick;
                    case Position.Right:
                        brick = new bool[this.brick.GetLength(1), this.brick.GetLength(0)];

                        for (int y = 0; y < this.brick.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.brick.GetLength(1); x++)
                            {
                                brick[x, y] = this.brick[(this.brick.GetLength(0) - y - 1), x];
                            }
                        }
                        return brick;
                    case Position.Left:
                        brick = new bool[this.brick.GetLength(1), this.brick.GetLength(0)];

                        for (int y = 0; y < this.brick.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.brick.GetLength(1); x++)
                            {
                                brick[x, y] = this.brick[y, (this.brick.GetLength(1) - x - 1)];
                            }
                        }
                        return brick;
                    default:
                        return null;
                }
            }
            set
            {
                if (value == null)
                    throw new NullReferenceException();

                if (value.GetLength(0) > 4 || value.GetLength(1) > 4)
                    throw new ArgumentOutOfRangeException();

                this.brick = value;
            }
        }

        public Position Position { get; protected set; }

        public virtual void Rotate(Position direction)
        {
            this.Position = direction;
        }

        public virtual T Color { get; set; }
    }
}
