using Blocks.Class.Bricks;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Functions
{
    public static class Collect
    {
        public static void Clear(this Field field)
        {
            List<int> rows = field.Rows();

            if(rows.Count > 0)
            {

            }
        }


        private static List<int> Rows(this Field field)
        {
            List<Point> points = new List<Point>();
            List<int> rows = new List<int>();

            // Whole function can be shorten up

            foreach (FieldBrick item in field.Elements)
            {
                if (item.GetHashCode() != field.Current.GetHashCode())
                    for (int y = 0; y < item.Brick.Height; y++)
                    {
                        for (int x = 0; x < item.Brick.Width; x++)
                        {
                            if (item.Brick.Appearance[y, x])
                                points.Add(new Point((item.Position.X + x), (item.Position.Y + y)));
                        }
                    }
            }

            for (int y = field.Size.Height; y > 0; --y)
            {
                bool line = false;

                for (int x = 0; x < field.Size.Width; x++)
                {
                    line = false;

                    foreach (Point point in points)
                    {
                        if (point.X == x && point.Y == y)
                        {
                            line = true;
                        }
                    }

                    if (!line)
                        break;
                }
                if (line)
                    rows.Add(y);
            }
            return rows;
        }
    }
}
