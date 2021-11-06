namespace RaGae.Game.Blocks.BrickLib
{
    public class SmashBoyBrick : BaseBrick
    {
        //     +---+---+
        //     |   |   |
        // +---+---+---+
        // |   |   |
        // +---+---+
        public SmashBoyBrick()
        {
            base.apperance = new bool[,]
            {
                { false,  true,  true  },
                { true,   true,  false }
            };
        }
    }
}
