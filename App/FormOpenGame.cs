using Ragae.Game.Blocks.GameLib.Provider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ragae.Game.Blocks.App
{
    public partial class FormOpenGame : Form
    {
        private StringBuilder fileBuilder;

        public FormOpenGame(StringBuilder fileBuilder)
        {
            this.InitializeComponent();
            this.fileBuilder = fileBuilder;
        }

        private void FormOpenGame_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(FileStorageProvider.TempPath))
                return;

            IEnumerable<string> tempFiles = Directory.GetFiles(FileStorageProvider.TempPath, "*.sav");

            if (tempFiles is null ||
                tempFiles.Count() < 1)
                return;

            tempFiles.ToList().ForEach(s => this.listBoxGame.Items.Add(Path.GetFileName(s)));
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (this.listBoxGame.SelectedIndex < 0)
                return;

            this.fileBuilder.Clear();
            this.fileBuilder.Append(this.listBoxGame.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.listBoxGame.SelectedItem is null)
                return;

            if (!File.Exists(Path.Combine(FileStorageProvider.TempPath, this.listBoxGame.SelectedItem.ToString())))
                return;

            File.Delete(Path.Combine(FileStorageProvider.TempPath, this.listBoxGame.SelectedItem.ToString()));
            this.listBoxGame.Items.Remove(this.listBoxGame.SelectedItem);
        }
    }
}
