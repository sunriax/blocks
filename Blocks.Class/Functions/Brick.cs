using Blocks.Class.Bricks;
using Blocks.Class.Functions;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Functions
{
    public static class Brick
    {
        public static Random random = new Random();

        public static void CreateBrick(this Field field, List<System.Drawing.Color> colors)
        {
            switch (random.Next(0,5))
            {
                case 1:
                    field.BuildElements(new BlueRickyBrick(), colors[random.Next(0, (colors.Count - 1))]);
                    break;
                case 2:
                    field.BuildElements(new ClevelandBrick(), colors[random.Next(0, (colors.Count - 1))]);
                    break;
                case 3:
                    field.BuildElements(new HeroBrick(), colors[random.Next(0, (colors.Count - 1))]);
                    break;
                case 4:
                    field.BuildElements(new OrangeRickyBrick(), colors[random.Next(0, (colors.Count - 1))]);
                    break;
                case 5:
                    field.BuildElements(new RhodeIslandBrick(), colors[random.Next(0, (colors.Count - 1))]);
                    break;
                default:
                    field.BuildElements(new SmashboyBrick(), colors[random.Next(0, (colors.Count - 1))]);
                    break;
            }
        }

        private static void BuildElements(this Field field, BaseBrick brick, System.Drawing.Color color)
        {
            if (!(field.Next is null))
                field.Elements.Add(field.Next);

            field.Next = new FieldBrick(brick)
            {
                Color = color,
                Position = new Point(0, (-brick.Height + 1))
            };
        }
    }
}
