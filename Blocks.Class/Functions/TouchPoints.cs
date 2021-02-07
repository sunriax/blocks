using Blocks.Class.Bricks;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.Class.Functions
{
    public static class TouchPoints
    {
        public static List<Point> Points(BaseBrick brick, Point position)
        {
            List<Point> currentBlock = new List<Point>();

            for (int y = 0; y < brick.Height; y++)
            {
                for (int x = 0; x < brick.Width; x++)
                {
                    if (brick.Appearance[y, x] == true)
                    {
                        currentBlock.Add(new Point(position.X + x, position.Y + y));
                    }
                }
            }
            return currentBlock;
        }

        public static bool Touch(List<Point> currentBrick, List<Point> fieldBrick, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    foreach (Point fieldPoint in fieldBrick)
                    {
                        foreach (Point currentPoint in currentBrick)
                        {
                            if ((currentPoint.Y == fieldPoint.Y) &&
                                ((currentPoint.X - 1) == fieldPoint.X))
                                return true;
                        }
                    }
                    return false;
                case Direction.Right:
                    foreach (Point fieldPoint in fieldBrick)
                    {
                        foreach (Point currentPoint in currentBrick)
                        {
                            if ( (currentPoint.Y == fieldPoint.Y) &&
                                ((currentPoint.X + 1) == fieldPoint.X))
                                return true;
                        }
                    }
                    return false;
                default:
                    foreach (Point fieldPoint in fieldBrick)
                    {
                        foreach (Point currentPoint in currentBrick)
                        {
                            if (((currentPoint.Y + 1) == fieldPoint.Y) &&
                                 (currentPoint.X == fieldPoint.X))
                                return true;
                        }
                    }
                    return false;
            }
        }

    }
}
