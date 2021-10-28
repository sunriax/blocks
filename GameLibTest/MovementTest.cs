using Ragae.Game.Blocks.GameLib;
using Ragae.Game.Blocks.GameLib.Factory;
using System.Drawing;
using static GameLibTest.Helper.GameLibHelper;
using Xunit;
using System.Collections.Generic;

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

        public static IEnumerable<object[]> GetMovementData()
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
                    i == 0 ? false : true
                };

                yield return new object[]
                {
                    new List<Item[]>()
                    {
                    },
                    i == 0 ? false : true
                };
            }
        }

        [Theory]
        [MemberData(nameof(GetMovementData))]
        public void CreateMovementAndMoveDownWithDifferentSettings_Passing(List<Item[]> line, bool toEnd)
        {
            Movement movement = factory.CreateMovement(factory.CreateField());
            movement.Field.Line.AddRange(line);

            Assert.NotNull(movement);
            Assert.NotNull(movement.Field);

            movement.Field.Current = factory.CreateFieldBrick(Color.Red);

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
