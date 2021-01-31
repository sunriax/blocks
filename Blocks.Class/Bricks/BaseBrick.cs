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
        private bool[,] defaultBrick =
        {
            { false, true,  false, false },
            { true,  true,  true,  true  },
            { false, true,  false, false }
        };

        private bool[,] currentBrick;

        public BaseBrick()
        {
            this.currentBrick = defaultBrick;
        }

        public bool[,] Brick
        {
            get
            {
                switch (this.Position)
                {
                    case Position.Down:
                        this.currentBrick = new bool[this.defaultBrick.GetLength(0), this.defaultBrick.GetLength(1)];

                        for (int y = 0; y < this.defaultBrick.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.defaultBrick.GetLength(1); x++)
                            {
                                this.currentBrick[y, x] = this.defaultBrick[(this.defaultBrick.GetLength(0) - y - 1), (this.defaultBrick.GetLength(1) - x - 1)];
                            }
                        }

                        return this.currentBrick;
                    case Position.Right:
                        this.currentBrick = new bool[this.defaultBrick.GetLength(1), this.defaultBrick.GetLength(0)];

                        for (int y = 0; y < this.defaultBrick.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.defaultBrick.GetLength(1); x++)
                            {
                                this.currentBrick[x, y] = this.defaultBrick[(this.defaultBrick.GetLength(0) - y - 1), x];
                            }
                        }

                        return this.currentBrick;
                    case Position.Left:
                        this.currentBrick = new bool[this.defaultBrick.GetLength(1), this.defaultBrick.GetLength(0)];

                        for (int y = 0; y < this.defaultBrick.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.defaultBrick.GetLength(1); x++)
                            {
                                this.currentBrick[x, y] = this.defaultBrick[y, (this.defaultBrick.GetLength(1) - x - 1)];
                            }
                        }

                        return this.currentBrick;
                    default:
                        this.currentBrick = this.defaultBrick;
                        return this.currentBrick;
                }
            }
            protected set
            {
                if (value == null)
                    throw new NullReferenceException();

                if (value.GetLength(0) > 4 || value.GetLength(1) > 4)
                    throw new ArgumentOutOfRangeException();

                this.defaultBrick = value;
            }
        }

        public Position Position { get; protected set; }

        public int Width { get => this.currentBrick.GetLength(1); }

        public int Height { get => this.currentBrick.GetLength(0); }

        public virtual void Rotate(Position direction)
        {
            this.Position = direction;
        }

        public T Color { get; set; }
    }
}
