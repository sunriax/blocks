using Blocks.Class.Bricks;
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
        }

        private void pictureBoxBlocks_Paint(object sender, PaintEventArgs e)
        {
            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int y = 0; y < this.brick.Brick.GetLength(0); y++)
            {
                for (int x = 0; x < this.brick.Brick.GetLength(1); x++)
                {
                    Rectangle rectantle = new Rectangle(x * 20 + 1, y * 20 + 1, 18, 18);

                    if (this.brick.Brick[y, x])
                        dev.FillRectangle(new SolidBrush(this.brick.Color), rectantle);
                }
            }
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                switch (this.brick.Position)
                {
                    case Position.Up:
                        this.brick.Rotate(Position.Right);
                        break;
                    case Position.Right:
                        this.brick.Rotate(Position.Down);
                        break;
                    case Position.Down:
                        this.brick.Rotate(Position.Left);
                        break;
                    case Position.Left:
                        this.brick.Rotate(Position.Up);
                        break;
                    default:
                        break;
                }
            }

            this.pictureBoxBlocks.Invalidate();
        }

        private void timerInterval_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.comboBoxLevel.Enabled = false;
            this.checkBoxSound.Enabled = false;
            this.buttonStart.Enabled = false;
        }
    }
}
