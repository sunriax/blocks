namespace RaGae.Game.Blocks.BrickLib
{
    public class RhodeIslandBrick : BaseBrick
    {
        public RhodeIslandBrick()
        {
            //     +---+---+
            //     |   |   |
            // +---+---+---+
            // |   |   |
            // +---+---+
            base.apperance = new bool[,]
            {
                { false,  true,  true  },
                { true,   true,  false }
            };
        }
    }
}
