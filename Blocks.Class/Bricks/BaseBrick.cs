using Blocks.Class.Game;
using System;
using System.Collections.Generic;

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
        private bool[,] defaultAppearance =
        {
            { false, true,  false, false },
            { true,  true,  true,  true  },
            { false, true,  false, false }
        };

        private bool[,] currentAppearance;

        public BaseBrick()
        {
            this.currentAppearance = defaultAppearance;
        }

        public bool[,] Appearance
        {
            get
            {
                switch (this.Position)
                {
                    case Position.Down:
                        this.currentAppearance = new bool[this.defaultAppearance.GetLength(0), this.defaultAppearance.GetLength(1)];

                        for (int y = 0; y < this.defaultAppearance.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.defaultAppearance.GetLength(1); x++)
                            {
                                this.currentAppearance[y, x] = this.defaultAppearance[(this.defaultAppearance.GetLength(0) - y - 1), (this.defaultAppearance.GetLength(1) - x - 1)];
                            }
                        }

                        return this.currentAppearance;
                    case Position.Right:
                        this.currentAppearance = new bool[this.defaultAppearance.GetLength(1), this.defaultAppearance.GetLength(0)];

                        for (int y = 0; y < this.defaultAppearance.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.defaultAppearance.GetLength(1); x++)
                            {
                                this.currentAppearance[x, y] = this.defaultAppearance[(this.defaultAppearance.GetLength(0) - y - 1), x];
                            }
                        }

                        return this.currentAppearance;
                    case Position.Left:
                        this.currentAppearance = new bool[this.defaultAppearance.GetLength(1), this.defaultAppearance.GetLength(0)];

                        for (int y = 0; y < this.defaultAppearance.GetLength(0); y++)
                        {
                            for (int x = 0; x < this.defaultAppearance.GetLength(1); x++)
                            {
                                this.currentAppearance[x, y] = this.defaultAppearance[y, (this.defaultAppearance.GetLength(1) - x - 1)];
                            }
                        }

                        return this.currentAppearance;
                    default:
                        this.currentAppearance = this.defaultAppearance;
                        return this.currentAppearance;
                }
            }
            protected set
            {
                if (value == null)
                    throw new NullReferenceException();

                if (value.GetLength(0) > 4 || value.GetLength(1) > 4)
                    throw new ArgumentOutOfRangeException();

                this.defaultAppearance = value;
            }
        }

        public Position Position { get; protected set; }

        public int Width { get => this.currentAppearance.GetLength(1); }

        public int Height { get => this.currentAppearance.GetLength(0); }

        public virtual void Rotate(Position direction)
        {
            this.Position = direction;
        }

        public T Color { get; set; }
    }
}
