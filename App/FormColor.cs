using Ragae.Game.Blocks.AppLib;
using Ragae.Game.Blocks.BrickLib;
using Ragae.Game.Blocks.DataLib;
using Ragae.Game.Blocks.DataLib.Converter;
using Ragae.Game.Blocks.GameLib;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Ragae.Game.Blocks.App
{
    public partial class FormColor : Form
    {
        private Field field;
        private Plot plotGraphics;

        public FormColor(Plot plotGraphics)
        {
            this.InitializeComponent();
            this.plotGraphics = plotGraphics;

            this.field = new(
                new Size(
                    (pictureBoxBrick.Size.Width / plotGraphics.BrickSize),
                    (pictureBoxBrick.Size.Height / plotGraphics.BrickSize)))
            {
                Next = new(BrickFactory.RandomBrick)
            };
        }

        private void FormColor_Load(object sender, EventArgs e)
        {
            this.buttonGrid.BackColor = Program.PresentationConfig.Grid;
            this.pictureBoxField.BackColor = this.buttonBackground.BackColor = Program.PresentationConfig.Background;

            this.listBoxBrick.Items.Clear();

            Program.PresentationConfig.Blocks.ForEach(c =>
            {
                this.listBoxBrick.Items.Add(c);
            });

            if (this.listBoxBrick.Items.Count < 1)
                return;

            this.listBoxBrick.SelectedIndex = 0;

            this.PictureBoxSetup();
        }

        private void FormColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DataService.Write(Path.Combine(nameof(Program.Config), $"{nameof(Presentation)}.json"), Program.PresentationConfig, new JsonSerializerOptions() { Converters = { new ColorJsonConverter() } }))
                MessageBox.Show(string.Format(Properties.StringResource.SavingDataError, nameof(Presentation)), Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonField_Click(object sender, EventArgs e)
        {
            Button b = (Button)(sender);

            ColorDialog dialog = new ColorDialog();

            if (b == this.buttonGrid)
                dialog.Color = Program.PresentationConfig.Grid;
            else if (b == this.buttonBackground)
                dialog.Color = Program.PresentationConfig.Background;
            else
                return;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            b.BackColor = dialog.Color;

            if (b == this.buttonGrid)
                Program.PresentationConfig.Grid = dialog.Color;
            else if (b == this.buttonBackground)
                Program.PresentationConfig.Background = dialog.Color;

            this.PictureBoxSetup();
        }

        private void listBoxBrick_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(Program.PresentationConfig.Blocks.ElementAt(e.Index)),
                new Rectangle(
                    new Point(
                        e.Bounds.X + 1,
                        e.Bounds.Y + 1),
                    new Size(
                        e.Bounds.Width - 2,
                        e.Bounds.Height - 2)));

            e.DrawFocusRectangle();
        }

        private void listBoxBrick_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox b = (ListBox)(sender);

            if (b is null ||
               b.Items.Count < 1 ||
               b.SelectedIndex < 0)
                return;

            this.field.Next.Color = Program.PresentationConfig.Blocks.ElementAt(b.SelectedIndex);
            this.pictureBoxBrick.Invalidate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog()
            {
                Color = Program.PresentationConfig.Blocks.ElementAt(listBoxBrick.SelectedIndex)
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            if (Program.PresentationConfig.Blocks.Any(x => x == dialog.Color))
                return;

            Program.PresentationConfig.Blocks.Add(dialog.Color);
            this.listBoxBrick.Items.Add(dialog.Color);
            this.listBoxBrick.SelectedIndex = (this.listBoxBrick.Items.Count - 1);
            this.pictureBoxBrick.Invalidate();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.listBoxBrick?.Items is null || this.listBoxBrick.SelectedIndex < 1)
                return;

            if (Program.PresentationConfig.Blocks.ElementAtOrDefault(this.listBoxBrick.SelectedIndex).IsEmpty)
                return;

            Program.PresentationConfig.Blocks.RemoveAt(this.listBoxBrick.SelectedIndex);
            this.listBoxBrick.Items.RemoveAt(this.listBoxBrick.SelectedIndex);
            this.listBoxBrick.SelectedIndex = (this.listBoxBrick.Items.Count - 1);
            this.pictureBoxBrick.Invalidate();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Program.PresentationConfig = new();
            this.FormColor_Load(sender, e);
        }

        private void pictureBoxBrick_Paint(object sender, PaintEventArgs e)
        {
            FieldBrick b = field.Next;

            if (b is null)
                return;

            PictureBox pb = (PictureBox)(sender);
            Graphics dev = e.Graphics;

            plotGraphics.Brick(
                dev,
                new Point(
                    pb.Width / 2 - (int)((b.Brick.Apperance.GetLength(1) / 2.0) * plotGraphics.BrickSize),
                    pb.Height / 2),
                new Point(
                    0, 
                    (int)((b.Brick.Apperance.GetLength(0) / 2.0 - 1))),
                b.Brick,
                b.Color);
        }

        private void PictureBoxSetup()
        {
            this.pictureBoxField.Image = plotGraphics.Grid(
             new Size(
                 pictureBoxField.Width,
                 pictureBoxField.Height
                 ),
             Program.PresentationConfig.Grid);

            this.pictureBoxBrick.Image = plotGraphics.Grid(
                new Size(
                    pictureBoxBrick.Width,
                    pictureBoxBrick.Height
                    ),
                Program.PresentationConfig.Grid);

            this.pictureBoxField.BackColor = this.pictureBoxBrick.BackColor = Program.PresentationConfig.Background;

            this.pictureBoxBrick.Invalidate();
            this.pictureBoxField.Invalidate();
        }
    }
}
