using RaGae.Game.Blocks.GameLib;
using RaGae.Game.Blocks.GameLib.Factory;
using System.Drawing;
using static GameLibTest.Helper.GameLibHelper;
using Xunit;
using System.Collections.Generic;
using RaGae.Game.Blocks.BrickLib;
using RaGae.Game.Blocks.BrickLib.Enumeration;

namespace GameLibTest
{
    public class MovementTest
    {
        private static GameFactory factory;

        public MovementTest() => factory = GameFactory.Instance(new Size(10, 10));

        [Fact]
        public void CreateMovement_Passing()
        {
            Movement movement = factory.CreateMovement(factory.CreateField());

            Assert.NotNull(movement);
            Assert.NotNull(movement.Field);
        }

        public static IEnumerable<BaseBrick> GetBrickData()
        {
            yield return new BlueRickyBrick();
            yield return new ClevelandBrick();
            yield return new HeroBrick();
            yield return new OrangeRickyBrick();
            yield return new RhodeIslandBrick();
            yield return new SmashBoyBrick();
            yield return new TeeWeeBrick();
        }

        public static IEnumerable<object[]> GetMovementData()
        {
            foreach (BaseBrick brick in GetBrickData())
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        yield return new object[]
                        {
                    new List<Item[]>()
                    {
                        FillLine(10),
                        FillLine(10),
                        FillLine(10),
                        FillLine(10)
                    },
                    brick,
                    j,
                    i == 0 ? false : true
                        };

                        yield return new object[]
                        {
                    new List<Item[]>()
                    {
                    },
                    brick,
                    j,
                    i == 0 ? false : true
                        };

                        yield return new object[]
                        {
                    new List<Item[]>()
                    {
                        FillLine(10),
                        HalfLine(10),
                        FillLine(10)
                    },
                    brick,
                    j,
                    i == 0 ? false : true
                        };
                    }
                }
            }
        }

        [Theory]
        [MemberData(nameof(GetMovementData))]
        public void CreateMovementAndMoveDownWithDifferentSettings_Passing(List<Item[]> line, BaseBrick brick, int rotate, bool toEnd)
        {
            Movement movement = factory.CreateMovement(factory.CreateField());
            movement.Field.Line.AddRange(line);

            Assert.NotNull(movement);
            Assert.NotNull(movement.Field);

            movement.Field.Current = new FieldBrick(brick)
            {
                Position = new Point(factory.Size.Width / 2, factory.Size.Height),
                Color = Color.Red
            };

            for (int j = 0; j < rotate; j++)
            {
                movement.Rotate(Rotation.Right);
            }

            int i = movement.Field.Current.Position.Y;

            while (movement.Down())
            {
                i--;

                if (!toEnd)
                    break;
            }

            Assert.Equal(toEnd, (movement.Field.Line.Count == i));
            Assert.Equal(toEnd, (movement.Field.Line.Count == movement.Field.Current.Position.Y));

            if (!toEnd)
                return;

            Assert.False(movement.Down());
        }
    }
}
