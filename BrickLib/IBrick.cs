using Ragae.Game.Blocks.BrickLib.Enumeration;

namespace Ragae.Game.Blocks.BrickLib
{
    public interface IBrick
    {
        public abstract bool[,] Apperance { get;  }
        public void Rotate(Rotation rotation);
    }
}
