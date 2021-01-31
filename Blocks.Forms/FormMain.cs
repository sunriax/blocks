using Blocks.Class.Bricks;
using Blocks.Class.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocks.Forms
{
    public partial class FormMain : Form
    {
        private int BRICK_SIZE = 20;

        private Field<Color> field;
        private Shifter<Color> shifter;

        //private BaseBrick<Color> brick = new BlueRickyBrick<Color>();
        //private BaseBrick<Color> brick = new ClevelandBrick<Color>();
        //private BaseBrick<Color> brick = new HeroBrick<Color>();
        //private BaseBrick<Color> brick = new OrangeRickyBrick<Color>();
        //private BaseBrick<Color> brick = new RhodeIslandBrick<Color>();
        //private BaseBrick<Color> brick = new SmashboyBrick<Color>();
        private BaseBrick<Color> brick = new TeeweeBrick<Color>();

        public FormMain()
        {
            this.brick.Color = Color.Red;

            InitializeComponent();

            this.pictureBoxBlocks.Width -= this.pictureBoxBlocks.Width % BRICK_SIZE;
            this.pictureBoxBlocks.Height -= this.pictureBoxBlocks.Height % BRICK_SIZE;

            this.field = new Field<Color>();
            this.field.Add(this.brick);
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
                        Rectangle rectantle = new Rectangle((x * BRICK_SIZE) + (BRICK_SIZE * (item.Position.X + 1) + 1), (y * BRICK_SIZE) + (BRICK_SIZE * (item.Position.Y + 1) + 1), BRICK_SIZE - 2, BRICK_SIZE - 2);

                        if (item.Brick.Brick[y, x])
                            dev.FillRectangle(new SolidBrush(item.Brick.Color), rectantle);
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
            if (e.KeyChar == (char)Keys.Space)
            {
                switch (this.field.Current.Brick.Position)
                {
                    case Position.Up:
                        this.field.Current.Brick.Rotate(Position.Right);
                        break;
                    case Position.Right:
                        this.field.Current.Brick.Rotate(Position.Down);
                        break;
                    case Position.Down:
                        this.field.Current.Brick.Rotate(Position.Left);
                        break;
                    case Position.Left:
                        this.field.Current.Brick.Rotate(Position.Up);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (e.KeyChar)
                {
                    case 'd':
                        this.shifter.Shift(Direction.Right);
                        break;
                    case 'a':
                        this.shifter.Shift(Direction.Left);
                        break;
                    case 's':
                        this.shifter.Shift(Direction.Down);
                        break;
                    default:
                        break;
                }
            }

            this.pictureBoxBlocks.Invalidate();
        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {
            if (this.shifter.Tick())
                this.field.Add(new BlueRickyBrick<Color>()
                {
                    Color = Color.Blue
                });
            this.pictureBoxBlocks.Invalidate();
        }
    }
}
