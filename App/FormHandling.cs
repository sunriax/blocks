using RaGae.Game.Blocks.AppLib;
using RaGae.Game.Blocks.BrickLib;
using RaGae.Game.Blocks.BrickLib.Enumeration;
using RaGae.Game.Blocks.DataLib;
using RaGae.Game.Blocks.DataLib.Config;
using RaGae.Game.Blocks.GameLib;
using RaGae.Game.Blocks.GameLib.Enumeration;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RaGae.Game.Blocks.App
{
    public partial class FormHandling : Form
    {
        private Field field;
        private Movement movement;
        private Plot plotGraphics;

        private bool pause;

        public FormHandling(Plot plotGraphics)
        {
            this.InitializeComponent();
            this.plotGraphics = plotGraphics;

            Bitmap bm = Properties.ImageResource.Run;
            this.pictureBoxRight.BackgroundImage = bm;

            this.RotateImage(bm, pictureBoxLeft, RotateFlipType.Rotate180FlipNone);
            this.RotateImage(bm, pictureBoxDown, RotateFlipType.Rotate90FlipNone);

            this.field = new(
                new Size(
                    (pictureBoxBrick.Size.Width / plotGraphics.BrickSize),
                    (pictureBoxBrick.Size.Height / plotGraphics.BrickSize)))
            {
                Current = new(BrickFactory.RandomBrick)
                {
                    Position = new Point(1, 1),
                    Color = Color.Red
                }
            };
            this.movement = new(this.field);

            this.pictureBoxBrick.Image = plotGraphics.Grid(
                new Size(
                    pictureBoxBrick.Width,
                    pictureBoxBrick.Height
                    ),
                Program.PresentationConfig.Grid);

            groupBoxKeys.Click += FormHandling_Click;
            groupBoxLeft.Click += FormHandling_Click;
            groupBoxRight.Click += FormHandling_Click;
            groupBoxDown.Click += FormHandling_Click;
            groupBoxRotate.Click += FormHandling_Click;
            groupBoxPause.Click += FormHandling_Click;
        }

        private void FormHandling_Load(object sender, EventArgs e)
        {
            this.textBoxLeft.Text = Program.HandlingConfig.Left.ToString();
            this.textBoxRight.Text = Program.HandlingConfig.Right.ToString();
            this.textBoxDown.Text = Program.HandlingConfig.Down.ToString();
            this.textBoxRotate.Text = Program.HandlingConfig.Rotate.ToString();
            this.textBoxPause.Text = Program.HandlingConfig.Pause.ToString();

            this.buttonFocus.Select();
        }

        private void FormHandling_Click(object sender, EventArgs e) => this.buttonFocus.Focus();

        private void FormHandling_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DataService.Write(Path.Combine(nameof(Program.Config), $"{nameof(Handling)}.json"), Program.HandlingConfig))
                MessageBox.Show(string.Format(Properties.StringResource.SavingDataError, nameof(Handling)), Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left ||
                keyData == Keys.Right ||
                keyData == Keys.Down ||
                keyData == Keys.Pause)
            {
                this.FormHandling_KeyDown(null, new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormHandling_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            if (Program.HandlingConfig.Left == (char)(key))
                key = Keys.Left;
            else if (Program.HandlingConfig.Right == (char)(key))
                key = Keys.Right;
            else if (Program.HandlingConfig.Down == (char)(key))
                key = Keys.Down;
            else if (Program.HandlingConfig.Rotate == (char)(key))
                key = Keys.Space;
            else if (Program.HandlingConfig.Pause == (char)(key))
                key = Keys.Pause;
                
            switch (key)
            {
                case Keys.Left:
                    movement.Move(Direction.Left);
                    break;
                case Keys.Right:
                    movement.Move(Direction.Right);
                    break;
                case Keys.Down:
                    if (!movement.Down())
                    {
                        this.field.Current.Position =
                            new Point(
                                this.field.Current.Position.X,
                                this.field.Current.Position.Y + 2);
                    }
                    break;
                case Keys.Space:
                    movement.Rotate(Rotation.Left);
                    break;
                case Keys.Pause:
                    this.pause = !this.pause;
                    break;
                default:
                    break;
            }
            this.pictureBoxBrick.Invalidate();
        }

        private void RotateImage(Bitmap bm, PictureBox box, RotateFlipType type)
        {
            Bitmap clone = (Bitmap)bm.Clone();
            clone.RotateFlip(type);
            box.BackgroundImage = clone;
        }

        private void pictureBoxRotateOptional_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            dev.DrawRectangle(Pens.Black,
                new Rectangle(
                    new Point(
                        0,
                        pictureBoxRotateOptional.Height / 4),
                    new Size(
                        pictureBoxRotateOptional.Width - 1,
                        pictureBoxRotateOptional.Height * 2 / 4)
                    ));

            dev.DrawLine(Pens.Black,
                new Point(
                    pictureBoxRotateOptional.Width / 8,
                    pictureBoxRotateOptional.Height * 5 / 8),
                new Point(
                    pictureBoxRotateOptional.Width * 7 / 8,
                    pictureBoxRotateOptional.Height * 5 / 8));

            dev.DrawLine(Pens.Black,
                new Point(
                    pictureBoxRotateOptional.Width / 8,
                    pictureBoxRotateOptional.Height * 4 / 8),
                new Point(
                    pictureBoxRotateOptional.Width / 8,
                    pictureBoxRotateOptional.Height * 5 / 8));

            dev.DrawLine(Pens.Black,
                new Point(
                    pictureBoxRotateOptional.Width * 7 / 8,
                    pictureBoxRotateOptional.Height * 4 / 8),
                new Point(
                    pictureBoxRotateOptional.Width * 7 / 8,
                    pictureBoxRotateOptional.Height * 5 / 8));
        }

        private void pictureBoxPauseStandard_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            dev.DrawString(
                nameof(Keys.Pause),
                SystemFonts.DefaultFont,
                Brushes.Black,
                new Point(
                    pictureBoxPause.Width / 2,
                    pictureBoxPause.Height / 2),
                new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });

            dev.DrawRectangle(
                Pens.Black,
                new Rectangle(
                    new Point(0, 0),
                    new Size(
                        pictureBoxPause.Width - 1,
                        pictureBoxPause.Height -1)
                    ));
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Program.HandlingConfig = new();
            this.textBox_TextChanged(new TextBox(), e);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox b = (TextBox)(sender);

            b.BackColor = Color.White;

            if (!string.IsNullOrWhiteSpace(b.Name) && 
                (b.Text.Length > 1 ||
                 b.Text.ToList().All(c => !char.IsLetter(c))))
            {
                b.BackColor = Color.Red;
                b.Focus();

                return;
            }

            if (b == this.textBoxLeft)
                Program.HandlingConfig.Left = this.textBoxLeft.Text[0];
            else if (b == this.textBoxRight)
                Program.HandlingConfig.Right = this.textBoxRight.Text[0];
            else if (b == this.textBoxDown)
                Program.HandlingConfig.Down = this.textBoxDown.Text[0];
            else if (b == this.textBoxRotate)
                Program.HandlingConfig.Rotate = this.textBoxRotate.Text[0];
            else if (b == this.textBoxPause)
                Program.HandlingConfig.Pause = this.textBoxPause.Text[0];
            else
                this.FormHandling_Load(sender, e);
        }

        private void pictureBoxBrick_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)(sender);

            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int start_x = pb.Width / 2 - plotGraphics.BrickSize * (pb.Width / (2 * plotGraphics.BrickSize));
            int start_y = pb.Height - 1;

            if(this.pause)
            {
                dev.DrawString(
                    nameof(Keys.Pause),
                    new Font(FontFamily.GenericSansSerif, 20),
                    Brushes.Black,
                    new Point(
                        pb.Width / 2,
                        pb.Height / 2),
                    new StringFormat()
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        });
            }

            if (field.Current is null)
                return;

            // Draw Brick
            plotGraphics.Brick(
                dev,
                new Point(
                    start_x,
                    start_y),
                new Point(
                    field.Current.Position.X,
                    field.Current.Position.Y + field.Current.Brick.Apperance.GetLength(0) - 1),
                field.Current.Brick,
                field.Current.Color);
        }
    }
}
