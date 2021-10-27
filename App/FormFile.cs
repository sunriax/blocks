using Ragae.Game.Blocks.AppLib;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ragae.Game.Blocks.App
{
    public partial class FormFile : Form
    {
        public FormFile(string title, string fileName, Size size)
        {
            this.InitializeComponent();
            this.Text = title;

            if (size.IsEmpty)
                this.Size = new(400, 200);
            else
                this.Size = size;

            if (File.Exists(fileName))
                this.richTextBoxVersion.Text = File.ReadAllText(fileName);
            else
                this.richTextBoxVersion.Text = nameof(FileNotFoundException);
        }

        private void richTextBoxVersion_LinkClicked(object sender, LinkClickedEventArgs e) => Link.Open(e.LinkText);
    }
}
