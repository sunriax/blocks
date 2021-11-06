using RaGae.Game.Blocks.BrickLib.Enumeration;

namespace RaGae.Game.Blocks.BrickLib
{
    public interface IBrick
    {
        public abstract bool[,] Apperance { get;  }
        public void Rotate(Rotation rotation);
    }
}
