using Ragae.Game.Blocks.GameLib;
using Ragae.Game.Blocks.GameLib.Factory;
using System.Drawing;
using static GameLibTest.Helper.GameLibHelper;
using Xunit;

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

        [Fact]
        public void CreateMovementWithEmptyFieldAndMoveDown_Passing()
        {
            Movement movement = factory.CreateMovement(factory.CreateField());

            Assert.NotNull(movement);
            Assert.NotNull(movement.Field);

            movement.Field.Current = factory.CreateFieldBrick(Color.Red);
            Point p = movement.Field.Current.Position;

            Assert.True(movement.Down());
            Assert.True((p.Y - 1) == movement.Field.Current.Position.Y);
        }

        [Fact]
        public void CreateMovementWithEmptyFieldAndMoveToEnd_Passing()
        {
            Movement movement = factory.CreateMovement(factory.CreateField());

            Assert.NotNull(movement);
            Assert.NotNull(movement.Field);

            movement.Field.Current = factory.CreateFieldBrick(Color.Red);

            while (movement.Down());

            Assert.False(movement.Down());
            Assert.True(0 == movement.Field.Current.Position.Y);
        }

        [Fact]
        public void CreateMovementWithFieldAndMoveToEnd_Passing()
        {
            Movement movement = factory.CreateMovement(factory.CreateField());

            Assert.NotNull(movement);
            Assert.NotNull(movement.Field);

            movement.Field.Line.Add(FillLine(factory.Size.Width));
            movement.Field.Current = factory.CreateFieldBrick(Color.Red);

            while (movement.Down()) ;

            Assert.False(movement.Down());
            Assert.True(1 == movement.Field.Current.Position.Y);
        }
    }
}
