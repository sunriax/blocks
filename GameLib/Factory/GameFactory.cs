using Ragae.Game.Blocks.BrickLib;
using System.Drawing;

namespace Ragae.Game.Blocks.GameLib.Factory
{
    public class GameFactory
    {
        private static GameFactory factory;

        private GameFactory(Size size) => this.Size = size;

        public static GameFactory Instance(Size size)
        {
            if(factory is null)
                factory = new GameFactory(size);

            return factory;
        }

        public Size Size { get; private set; }

        public Field CreateField() => new Field(this.Size);

        public Movement CreateMovement(Field field) => new Movement(field);

        public FieldBrick CreateFieldBrick(Color color)
        {
            return new FieldBrick(BrickFactory.RandomBrick)
            {
                Color = color,
                Position = new Point(this.Size.Width / 2, this.Size.Height)
            };
        }
    }
}
