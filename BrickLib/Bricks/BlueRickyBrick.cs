namespace RaGae.Game.Blocks.BrickLib
{
    public class BlueRickyBrick : BaseBrick
    {
        // +---+
        // |   |
        // +---+---+---+
        // |   |   |   |
        // +---+---+---+

        public BlueRickyBrick()
        {
            base.apperance = new bool[,]
            {
                { true,  false, false },
                { true,  true,  true  }
            };
        }
    }
}
