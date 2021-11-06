namespace RaGae.Game.Blocks.BrickLib
{
    public class HeroBrick : BaseBrick
    {
        // +---+---+---+---+
        // |   |   |   |   |
        // +---+---+---+---+
        public HeroBrick()
        {
            base.apperance = new bool[,]
            {
                { true,  true, true, true }
            };
        }
    }
}
