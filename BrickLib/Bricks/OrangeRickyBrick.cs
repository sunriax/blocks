namespace Ragae.Game.Blocks.BrickLib
{
    public class OrangeRickyBrick : BaseBrick
    {
        //         +---+
        //         |   |
        // +---+---+---+
        // |   |   |   |
        // +---+---+---+
        public OrangeRickyBrick()
        {
            base.apperance = new bool[,]
            {
                { false, false, true },
                { true,  true,  true }
            };
        }
    }
}
