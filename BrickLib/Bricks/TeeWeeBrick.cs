namespace Ragae.Game.Blocks.BrickLib
{
    public class TeeWeeBrick : BaseBrick
    {
        //     +---+
        //     |   |
        // +---+---+---+
        // |   |   |   |
        // +---+---+---+
        public TeeWeeBrick()
        {
            base.apperance = new bool[,]
            {
                { false,  true,  false },
                { true,   true,  true  }
            };
        }
    }
}
