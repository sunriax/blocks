using RaGae.Game.Blocks.BrickLib.Enumeration;

namespace RaGae.Game.Blocks.BrickLib
{
    public abstract class BaseBrick : IBrick
    {
        protected bool[,] apperance;

        public bool[,] Apperance => this.apperance;

        public void Rotate(Rotation rotation)
        {
            switch (rotation)
            {
                case Rotation.Right:
                    DoRotation();
                    break;
                case Rotation.Left:
                    DoRotation();
                    DoRotation();
                    DoRotation();
                    break;
            }
        }

        private void DoRotation()
        {
            bool[,] temp = new bool[Apperance.GetLength(1), Apperance.GetLength(0)];

            for (int y = 0; y < Apperance.GetLength(0); y++)
            {
                for (int x = 0; x < Apperance.GetLength(1); x++)
                {
                    temp[(Apperance.GetLength(1) - x - 1), y] = Apperance[y, x];
                }
            }
            this.apperance = temp;
        }
    }
}
