using RaGae.Game.Blocks.GameLib;
using RaGae.Game.Blocks.GameLib.Factory;
using RaGae.Game.Blocks.LineLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace RaGae.Game.Blocks.Line
{
    class Program
    {
        private static GameFactory gameFactory = GameFactory.Instance(new Size(10, 14));
        private static Manager gameManager = new Manager(gameFactory);

        static void Main(string[] args)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Console.SetWindowSize(Console.WindowWidth, gameManager.Field.Size.Height * 2 + 10);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(nameof(Blocks));

            Console.WriteLine(new string(' ', (Console.WindowWidth - nameof(Blocks).Length)));
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.Write(Environment.NewLine);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            for (int y = 0; y < gameManager.Field.Size.Height; y++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" ");

                Console.BackgroundColor = ConsoleColor.White;
                for (int x = 0; x < gameManager.Field.Size.Width; x++)
                {
                    Console.Write("+---");
                }
                Console.Write("+");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.ResetColor();

                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" ");

                Console.BackgroundColor = ConsoleColor.White;
                for (int x = 0; x < gameManager.Field.Size.Width; x++)
                {
                    Console.Write("|   ");
                }
                Console.Write("|");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.ResetColor();
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");

            Console.BackgroundColor = ConsoleColor.White;
            for (int x = 0; x < gameManager.Field.Size.Width; x++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("+---");
            }
            Console.Write("+");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.ResetColor();

            for (int x = 0; x < gameManager.Field.Size.Width; x++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("    ");
            }
            Console.WriteLine("   ");
            Console.ResetColor();

            NextBrick(new Point(gameManager.Field.Size.Width * 5, 3), new Size(6, 4));
            Score(new Point(gameManager.Field.Size.Width * 5, 15), new Size(6, 5), gameManager.Score);

            Menu(
                new Point(
                    0,
                    Console.WindowHeight - 3
                    ),
                new List<Menu>()
                {
                    new Menu { Key = ConsoleKey.N, Description = "New" },
                    new Menu { Key = ConsoleKey.S, Description = "Save" },
                    new Menu { Key = ConsoleKey.P, Description = "Pause" }
                });

            Menu(
                new Point(
                    -Console.WindowWidth,
                    Console.WindowHeight - 3
                    ),
                new List<Menu>()
                {
                    new Menu { Key = ConsoleKey.M, Description = "Menu" },
                    new Menu { Key = ConsoleKey.Q, Description = "Quit" },
                    new Menu { Key = ConsoleKey.F1, Description = "Help" }
                });

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Q:
                            return;
                        case ConsoleKey.F1:

                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static void Menu(Point start, IEnumerable<Menu> keys)
        {
            if (start.X < 0)
            {
                int length = 0;

                foreach (Menu menu in keys)
                {
                    length += menu.ToString().Length + 3;
                }

                start = new Point(-(start.X + length + 1), start.Y);
            }

            Console.SetCursorPosition(start.X, start.Y);
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            for (int x = 0; x < keys.Count(); x++)
            {
                Console.Write("+");
                for (int i = 0; i < keys.ElementAt(x).ToString().Length; i++)
                {
                    Console.Write("-");
                }
                Console.Write("--");
            }
            Console.Write("+");

            Console.SetCursorPosition(start.X, start.Y + 1);

            for (int x = 0; x < keys.Count(); x++)
            {
                Console.Write("| ");
                Console.Write(keys.ElementAt(x).ToString());
                Console.Write(" ");
            }
            Console.Write("|");

            Console.SetCursorPosition(start.X, (start.Y + 2));

            for (int x = 0; x < keys.Count(); x++)
            {
                Console.Write("+");
                for (int i = 0; i < keys.ElementAt(x).ToString().Length; i++)
                {
                    Console.Write("-");
                }
                Console.Write("--");
            }
            Console.Write("+");
            Console.ResetColor();
        }

        private static void NextBrick(Point start, Size size)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(start.X, start.Y);
            Console.Write(Properties.StringResource.NextBrick);
            Console.Write(new string(' ', size.Width * 4 + 1 - Properties.StringResource.NextBrick.Length));

            Console.ForegroundColor = ConsoleColor.Gray;

            for (int y = 0; y < size.Height; y++)
            {
                Console.SetCursorPosition(start.X, (start.Y + 1 + 2 * y));
                for (int x = 0; x < size.Width; x++)
                {
                    Console.Write("+---");
                }
                Console.Write("+");

                Console.SetCursorPosition(start.X, (start.Y + 2 + 2 * y));
                for (int x = 0; x < size.Width; x++)
                {
                    Console.Write("|   ");
                }
                Console.Write("|");
            }
            Console.SetCursorPosition(start.X, start.Y + 1 + size.Height * 2);
            for (int x = 0; x < size.Width; x++)
            {
                Console.Write("+---");
            }
            Console.Write("+");

            Console.ResetColor();
        }

        private static void Score(Point start, Size size, int score)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(start.X, start.Y);
            Console.Write(Properties.StringResource.Score);
            Console.Write(new string(' ', size.Width * 4 + 1 - Properties.StringResource.Score.Length));

            Console.ForegroundColor = ConsoleColor.Gray;

            for (int y = 0; y < size.Height; y++)
            {
                if(y == 0 || y == (size.Height - 1))
                {
                    Console.SetCursorPosition(start.X, (start.Y + 1 + y));

                    for (int x = 0; x < (size.Width * 4); x++)
                    {
                        if(x == 0)
                        {
                            Console.Write("+");
                            continue;
                        }
                        Console.Write("-");
                    }
                    Console.Write("+");
                }
                else
                {
                    Console.SetCursorPosition(start.X, (start.Y + 1 + y));
                    Console.Write("| ");

                    if((size.Height / 2) == y)
                    {
                        Console.Write(new string(' ', size.Width * 4 - 3 - score.ToString().Length));
                        Console.Write(score);
                    }
                    else
                    {
                        Console.Write(new string(' ', size.Width * 4 - 3));
                    }

                    Console.Write(" |");
                }
            }

            Console.ResetColor();
        }
    }
}
