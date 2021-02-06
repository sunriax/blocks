using Blocks.Class.Bricks;
using Blocks.Class.Functions;
using Blocks.Class.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocks.Forms
{
    public partial class FormMain : Form
    {
        private int BRICK_SIZE = 20;

        private List<Color> colors = new List<Color>()
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Magenta,
            Color.Aqua,
            Color.Brown,
            Color.BlueViolet,
            Color.AliceBlue,
            Color.Beige,
            Color.DarkGreen,
            Color.DarkBlue
        };

        private Field<Color> field;
        private Shifter<Color> shifter;

        private SoundPlayer player = new SoundPlayer()
        {
            SoundLocation = "./Tetris.wav"
        };

        public FormMain()
        {
            InitializeComponent();

            this.pictureBoxBlocks.Width -= this.pictureBoxBlocks.Width % BRICK_SIZE - 2;
            this.pictureBoxBlocks.Height -= this.pictureBoxBlocks.Height % BRICK_SIZE - 2;

            this.field = new Field<Color>();
            this.shifter = new Shifter<Color>(this.field);
            this.shifter.Size = new FieldSize(this.pictureBoxBlocks.Width / BRICK_SIZE, this.pictureBoxBlocks.Height / BRICK_SIZE);
        }

        private void pictureBoxBlocks_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (FieldBrick<Color> item in this.field.Elements)
            {
                for (int y = 0; y < item.Brick.Height; y++)
                {
                    for (int x = 0; x < item.Brick.Width; x++)
                    {
                        Rectangle rectantle = new Rectangle(((x * BRICK_SIZE) + (BRICK_SIZE * item.Position.X) + 1), ((y * BRICK_SIZE) + (BRICK_SIZE * item.Position.Y) + 1), (BRICK_SIZE - 2), (BRICK_SIZE - 2));

                        if (item.Brick.Appearance[y, x])
                        {
                            dev.FillRectangle(new SolidBrush(item.Brick.Color), rectantle);

                            rectantle.X -= 1;
                            rectantle.Y -= 1;
                            rectantle.Width = BRICK_SIZE;
                            rectantle.Height = BRICK_SIZE;

                            dev.DrawRectangle(Pens.Gray, rectantle);
                        }
                    }
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.timerInterval.Enabled = true;
            this.timerInterval.Start();

            this.comboBoxLevel.Enabled = false;
            this.checkBoxSound.Enabled = false;
            this.buttonStart.Enabled = false;
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Space:
                    this.shifter.Rotate();
                    break;
                case 'd':
                    this.shifter.Move(Direction.Right);
                    break;
                case 'a':
                    this.shifter.Move(Direction.Left);
                    break;
                case 's':
                    this.shifter.Move(Direction.Down);
                    break;
                default:
                    break;
            }
            this.pictureBoxBlocks.Invalidate();
        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            if (this.shifter.Tick())
            {
                Random r = new Random();

                Color c = this.colors.ElementAt(r.Next(0, (this.colors.Count - 1)));

                switch (r.Next(0, 5))
                {
                    case 1:
                        this.field.Add(new BlueRickyBrick<Color>()
                        {
                            Color = c
                        });
                        break;
                    case 2:
                        this.field.Add(new ClevelandBrick<Color>()
                        {
                            Color = c
                        });
                        break;
                    case 3:
                        this.field.Add(new HeroBrick<Color>()
                        {
                            Color = c
                        });
                        break;
                    case 4:
                        this.field.Add(new OrangeRickyBrick<Color>()
                        {
                            Color = c
                        });
                        break;
                    case 5:
                        this.field.Add(new RhodeIslandBrick<Color>()
                        {
                            Color = c
                        });
                        break;
                    default:
                        this.field.Add(new SmashboyBrick<Color>()
                        {
                            Color = c
                        });
                        break;
                }
            }

            this.pictureBoxBlocks.Invalidate();
        }

        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxSound.Checked)
                player.PlayLooping();
            else
                player.Stop();
        }
    }
}
