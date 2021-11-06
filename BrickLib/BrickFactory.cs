using System;
using System.Security.Cryptography;

namespace RaGae.Game.Blocks.BrickLib
{
    public static class BrickFactory
    {
        private static readonly string[] bricks =
        {
            nameof(BlueRickyBrick),
            nameof(TeeWeeBrick),
            nameof(ClevelandBrick),
            nameof(HeroBrick),
            nameof(OrangeRickyBrick),
            nameof(RhodeIslandBrick),
            nameof(SmashBoyBrick)
        };

        public static BaseBrick CreateBrick(string name)
        {
            switch (name)
            {
                case nameof(BlueRickyBrick):
                    return new BlueRickyBrick();
                case nameof(ClevelandBrick):
                    return new ClevelandBrick();
                case nameof(HeroBrick):
                    return new HeroBrick();
                case nameof(OrangeRickyBrick):
                    return new OrangeRickyBrick();
                case nameof(RhodeIslandBrick):
                    return new RhodeIslandBrick();
                case nameof(SmashBoyBrick):
                    return new SmashBoyBrick();
                case nameof(TeeWeeBrick):
                    return new TeeWeeBrick();
                default:
                    throw new NullReferenceException($"{nameof(BrickFactory)}.{nameof(CreateBrick)}");
            }
        }
        public static BaseBrick RandomBrick => CreateBrick(bricks[RandomNumberGenerator.GetInt32(bricks.Length)]);
    }
}
