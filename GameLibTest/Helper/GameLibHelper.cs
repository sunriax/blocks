using Ragae.Game.Blocks.GameLib;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GameLibTest.Helper
{
    public static class GameLibHelper
    {

        public static void FillBlock(List<Item[]> line, Size size) => line.AddRange(Enumerable.Repeat(FillLine(size.Width), size.Height).ToArray());

        public static Item[] FillLine(int width) => Enumerable.Repeat(new Item() { Color = Color.Blue }, width).ToArray();

        public static Item[] EmptyLine(int width) => new Item[width];

        public static bool CheckFieldPosition(List<Item[]> line, FieldBrick fieldBrick)
        {
            for (int y = 0; y < fieldBrick.Brick.Apperance.GetLength(0); y++)
            {
                for (int x = 0; x < fieldBrick.Brick.Apperance.GetLength(1); x++)
                {
                    if (fieldBrick.Brick.Apperance[(fieldBrick.Brick.Apperance.GetLength(0) - 1 - y), x])
                    {
                        if (line.ElementAt(fieldBrick.Position.Y + y)[fieldBrick.Position.X + x] is not Item)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
