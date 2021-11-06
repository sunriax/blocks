using RaGae.Game.Blocks.LineLib.Enumeration;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RaGae.Game.Blocks.LineLib
{

    public static class Plot
    {
        public static IEnumerable<string> Box(this string text, Size size, Border border, Alignment horizontal = Alignment.Center, Alignment vertical = Alignment.Center)
        {
            List<string> box = new();

            if ((border & Border.Top) == Border.Top)
            {
                box.Add(BorderLine(size.Width, border));
            }

            for (int y = 0; y < size.Height; y++)
            {
                if(vertical == Alignment.Top)
                {
                    if(y == 0)
                    {
                        box.Add(text.TextLine(size.Width, border, horizontal));
                    }
                }
                else if (vertical == Alignment.Bottom)
                {
                    if (y == (size.Height - 1))
                    {
                        box.Add(text.TextLine(size.Width, border, horizontal));
                    }
                }
                else
                {
                    if (y == (size.Height / 2))
                    {
                        box.Add(text.TextLine(size.Width, border, horizontal));
                    }
                }
            }

            if ((border & Border.Bottom) == Border.Bottom)
            {
                box.Add(BorderLine(size.Width, border));
            }

            return null;
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

        private static string TextLine(this string text, int width, Border border, Alignment alignment)
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
