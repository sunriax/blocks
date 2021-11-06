namespace RaGae.Game.Blocks.BrickLib
{
    public class ClevelandBrick : BaseBrick
    {
        // +---+---+
        // |   |   |
        // +---+---+---+
        //     |   |   |
        //     +---+---+
        public ClevelandBrick()
        {
            base.apperance = new bool[,]
            {
                { true,  true,  false },
                { false, true,  true  }
            };
        }
    }
}
