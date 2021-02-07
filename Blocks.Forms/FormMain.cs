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

        private Field field;
        private Random random = new Random();

        private SoundPlayer player = new SoundPlayer()
        {
            SoundLocation = "./Tetris.wav"
        };

        public FormMain()
        {
            InitializeComponent();

            this.pictureBoxBlocks.Width -= this.pictureBoxBlocks.Width % BRICK_SIZE - 2;
            this.pictureBoxBlocks.Height -= this.pictureBoxBlocks.Height % BRICK_SIZE - 2;

            this.field = new Field(this.pictureBoxBlocks.Width / BRICK_SIZE, this.pictureBoxBlocks.Height / BRICK_SIZE);
        }

        private void pictureBoxBlocks_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if(this.checkBoxGrid.Checked)
            {
                for (int y = 0; y <= this.field.Size.Height; y++)
                {
                    dev.DrawLine(Pens.LightGray, 0, (y * BRICK_SIZE), (this.field.Size.Width * BRICK_SIZE), (y * BRICK_SIZE));
                }
                for (int x = 0; x <= this.field.Size.Width; x++)
                {
                    dev.DrawLine(Pens.LightGray, (x * BRICK_SIZE), 0, (x * BRICK_SIZE), (this.field.Size.Height * BRICK_SIZE));
                }
            }

            foreach (FieldBrick item in this.field.Elements)
            {
                for (int y = 0; y < item.Brick.Height; y++)
                {
                    for (int x = 0; x < item.Brick.Width; x++)
                    {
                        Rectangle rectantle = new Rectangle(((x * BRICK_SIZE) + (BRICK_SIZE * item.Position.X) + 1), ((y * BRICK_SIZE) + (BRICK_SIZE * item.Position.Y) + 1), (BRICK_SIZE - 2), (BRICK_SIZE - 2));

                        if (item.Brick.Appearance[y, x])
                        {
                            dev.FillRectangle(new SolidBrush(item.Color), rectantle);

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

        private void groupBoxRanking_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (this.field.Next is null)
                return;

            int brickSize = (int)(this.groupBoxRanking.Height / 2.0 - this.groupBoxRanking.Height * 0.2);
            int xStart = (int)((this.groupBoxRanking.Width / 2.0) - (brickSize * (this.field.Next.Brick.Width / 2.0)));
            int yStart = (int)((this.groupBoxRanking.Height / 2.0) - (brickSize * (this.field.Next.Brick.Height / 2.0)));

            for (int y = 0; y < this.field.Next.Brick.Height; y++)
            {
                for (int x = 0; x < this.field.Next.Brick.Width; x++)
                {

                    Rectangle rectantle = new Rectangle((xStart + (x * brickSize)), (yStart + (y * brickSize)), (brickSize - 2), (brickSize - 2));

                    if (this.field.Next.Brick.Appearance[y, x])
                    {
                        dev.FillRectangle(new SolidBrush(field.Next.Color), rectantle);

                        rectantle.X -= 1;
                        rectantle.Y -= 1;
                        rectantle.Width = brickSize;
                        rectantle.Height = brickSize;

                        dev.DrawRectangle(Pens.Gray, rectantle);
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
            this.checkBoxGrid.Enabled = false;
            this.buttonStart.Enabled = false;
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Space:
                    this.field.Rotate();
                    break;
                case 'd':
                    this.field.Move(Direction.Right);
                    break;
                case 'a':
                    this.field.Move(Direction.Left);
                    break;
                case 's':
                    this.field.Move(Direction.Down);
                    break;
                default:
                    break;
            }
            this.pictureBoxBlocks.Invalidate();
        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            if (this.field.Tick())
            {
                this.field.CreateBrick(colors);
                
                if(!(this.field.Next is null))
                    this.groupBoxRanking.Invalidate();
            }

            this.pictureBoxBlocks.Invalidate();
        }

        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBoxSound.Checked)
                    player.PlayLooping();
                else
                    player.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
