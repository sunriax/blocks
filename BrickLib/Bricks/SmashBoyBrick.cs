namespace RaGae.Game.Blocks.BrickLib
{
    public class SmashBoyBrick : BaseBrick
    {
        // +---+---+
        // |   |   |
        // +---+---+
        // |   |   |
        // +---+---+
        public SmashBoyBrick()
        {
            base.apperance = new bool[,]
            {
                { true,  true },
                { true,  true }
            };
        }
    }
}
