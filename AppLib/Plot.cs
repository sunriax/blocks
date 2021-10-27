using Ragae.Game.Blocks.BrickLib;
using System.Drawing;

namespace Ragae.Game.Blocks.AppLib
{
    public class Plot
    {
        public Plot(int brickSize = 0)
        {
            if(brickSize > 0)
                this.BrickSize = brickSize;
        }

        public int BrickSize { get; private set; } = 20;

        public void Brick(Graphics dev, Point start, Point offset, BaseBrick brick, Color color)
        {
            for (int y = 0; y < brick.Apperance.GetLength(0); y++)
            {
                for (int x = 0; x < brick.Apperance.GetLength(1); x++)
                {
                    if (brick.Apperance[y, x])
                    {
                        this.Block(dev, color, new Point(start.X + this.BrickSize * (offset.X + x), start.Y - this.BrickSize * (offset.Y - y)));
                    }
                }
            }
        }

        public void Block(Graphics dev, Color color, Point start)
        {
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            dev.DrawRectangle(
                            new Pen(Brushes.LightGray, 2),
                            new Rectangle(
                                new Point(
                                    start.X,
                                    start.Y - this.BrickSize),
                                new Size(
                                    new Point(
                                        this.BrickSize,
                                        this.BrickSize))));

            dev.FillRectangle(
                new SolidBrush(color),
                new Rectangle(
                    new Point(
                        start.X + 1,
                        start.Y + 1 - this.BrickSize),
                    new Size(
                        new Point(
                            this.BrickSize - 2,
                            this.BrickSize - 2))));
        }


        public Bitmap Grid(Size size, Color color)
        {
            Bitmap bm = new Bitmap(size.Width, size.Height);
            Graphics dev = Graphics.FromImage(bm);
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int start_x = size.Width / 2 - this.BrickSize * (size.Width / (2 * this.BrickSize));
            int start_y = size.Height - 1;
            int stop_x = size.Width / 2 + this.BrickSize * (size.Width / (2 * this.BrickSize));
            int stop_y = start_y - this.BrickSize * (size.Height / this.BrickSize);

            // Draw Grid
            for (int x = 0; x < (stop_x - start_x + 1); x += this.BrickSize)
            {
                dev.DrawLine(new Pen(new SolidBrush(color)), start_x + x, start_y, start_x + x, stop_y);
            }

            for (int y = 0; y < (start_y - stop_y + 1); y += this.BrickSize)
            {
                dev.DrawLine(new Pen(new SolidBrush(color)), start_x, start_y - y, stop_x, start_y - y);
            }

            return bm;
        }

    }
}
