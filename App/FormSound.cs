using RaGae.Game.Blocks.DataLib;
using RaGae.Game.Blocks.DataLib.Config;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace RaGae.Game.Blocks.App
{
    public partial class FormSound : Form
    {
        private SoundPlayer player;
        private Button currentButton;

        public FormSound(SoundPlayer player)
        {
            this.InitializeComponent();

            this.player = player;
        }

        private void FormSound_Load(object sender, EventArgs e)
        {
            this.textBoxFolder.Text = Program.SoundConfig.Folder;
            this.textBoxGame.Text = Program.SoundConfig.Game;
            this.textBoxMultiRow.Text = Program.SoundConfig.MultiRow;
            this.textBoxPause.Text = Program.SoundConfig.Pause;
            this.textBoxGameOver.Text = Program.SoundConfig.GameOver;
        }

        private void FormSound_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.player.Stop();

            if (!DataService.Write(Path.Combine(nameof(Program.Config), $"{nameof(Sound)}.json"), Program.SoundConfig))
                MessageBox.Show(string.Format(Properties.StringResource.SavingDataError, nameof(Sound)), Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                SelectedPath = Program.SoundConfig.Folder
            };

            if (dialog.ShowDialog() != DialogResult.OK ||
                !Directory.Exists(dialog.SelectedPath) ||
                dialog.SelectedPath == Program.SoundConfig.Folder)
                return;

            Program.SoundConfig.Folder = dialog.SelectedPath;

            this.textBoxFolder.Text = Program.SoundConfig.Folder;
            this.textBoxGame.Text = string.Empty;
            this.textBoxMultiRow.Text = string.Empty;
            this.textBoxPause.Text = string.Empty;
            this.textBoxGameOver.Text = string.Empty;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            Button b = (Button)(sender);

            if (b == this.buttonGameFile)
                Program.SoundConfig.Game = SelectFile(this.textBoxGame);
        }

        private string SelectFile(TextBox box)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = Program.SoundConfig.Folder,
                Filter = "wav Files|*.wav"
            };

            if (dialog.ShowDialog() != DialogResult.OK ||
                !File.Exists(dialog.FileName))
                return string.Empty;

            box.Text = dialog.SafeFileName;
            return dialog.SafeFileName;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Button b = (Button)(sender);

            if (currentButton is not null)
            {
                if (b.Name == currentButton.Name)
                {
                    this.currentButton = null;
                    this.player.Stop();
                    b.Image = Properties.ImageResource.Run;
                }
                return;
            }

            if (b == this.buttonGamePlay)
                this.PlaySound(this.textBoxGame.Text, b);
            else if (b == this.buttonMultiRowPlay)
                this.PlaySound(this.textBoxMultiRow.Text, b);
            else if (b == this.buttonPausePlay)
                this.PlaySound(this.textBoxPause.Text, b);
            else if (b == this.buttonGameOverPlay)
                this.PlaySound(this.textBoxGameOver.Text, b);

            this.currentButton = b;
            b.Image = Properties.ImageResource.Stop;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Program.SoundConfig = new();

            this.FormSound_Load(sender, e);
        }

        private void PlaySound(string file, Button button)
        {
            this.player.SoundLocation = Path.Combine(Program.SoundConfig.Folder, file);
            this.player.PlayLooping();
        }
    }
}
