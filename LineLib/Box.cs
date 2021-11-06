using RaGae.Game.Blocks.LineLib.Enumeration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaGae.Game.Blocks.LineLib
{
    public class Box
    {
        public Box(string text) => this.Text = text;

        public string Text { get; private set; }

        public Size Size { get; set; }
        public BoxColor Color { get; set; }

        public Border Border { get; set; }
        public Alignment Horizontal { get; set; }
        public Alignment Vertical { get; set; }

        public static IEnumerable<string> Texture(Box box)
        {
            List<string> texture = new();

            if ((box.Border & Border.Top) == Border.Top)
            {
                texture.Add(BorderLine(box.Size.Width, box.Border));
            }

            for (int y = 0; y < box.Size.Height; y++)
            {
                if (box.Vertical == Alignment.Top)
                {
                    if (y == 0)
                    {
                        texture.Add(TextLine(box.Text, box.Size.Width, box.Border, box.Horizontal));
                    }
                }
                else if (box.Vertical == Alignment.Bottom)
                {
                    if (y == (box.Size.Height - 1))
                    {
                        texture.Add(TextLine(box.Text, box.Size.Width, box.Border, box.Horizontal));
                    }
                }
                else
                {
                    if (y == (box.Size.Height / 2))
                    {
                        texture.Add(TextLine(box.Text, box.Size.Width, box.Border, box.Horizontal));
                    }
                }
            }

            if ((box.Border & Border.Bottom) == Border.Bottom)
            {
                texture.Add(BorderLine(box.Size.Width, box.Border));
            }

            return texture;
        }

        private static string BorderLine(int width, Border border)
        {
            StringBuilder line = new StringBuilder();

            if ((border & Border.Left) == Border.Left)
            {
                line.Append("+");
            }

            line.Append(new string('-', width));

            if ((border & Border.Right) == Border.Right)
            {
                line.Append("+");
            }

            return line.ToString();
        }

        private static string TextLine(string text, int width, Border border, Alignment alignment)
        {
            StringBuilder line = new StringBuilder();

            if ((border & Border.Left) == Border.Left)
            {
                line.Append("| ");
                width--;
            }

            if ((border & Border.Right) == Border.Right)
            {
                width--;
            }


            if (string.IsNullOrEmpty(text))
            {
                line.Append(new string(' ', width));
            }
            else
            {
                if (alignment == Alignment.Left)
                {
                    line.Append(text);
                    line.Append(new string(' ', (width - text.Length));
                }
                else if (alignment == Alignment.Right)
                {
                    line.Append(new string(' ', (width - text.Length)));
                    line.Append(text);
                }
                else
                {
                    line.Append(new string(' ', (1 / 2 * (width - text.Length))));
                    line.Append(text);
                    line.Append(new string(' ', (1 / 2 * (width - text.Length))));
                }
            }

            if ((border & Border.Right) == Border.Right)
            {
                line.Append(" |");
            }

            return line.ToString();
        }
    }
}
