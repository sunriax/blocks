namespace Ragae.Game.Blocks.BrickLib
{
    public class RhodeIslandBrick : BaseBrick
    {
        // +---+---+
        // |   |   |
        // +---+---+
        // |   |   |
        // +---+---+
        public RhodeIslandBrick()
        {
            base.apperance = new bool[,]
            {
                { true,  true },
                { true,  true }
            };
        }
    }
}
