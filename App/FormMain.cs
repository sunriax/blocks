using RaGae.Game.Blocks.AppLib;
using RaGae.Game.Blocks.BrickLib.Enumeration;
using RaGae.Game.Blocks.DataLib;
using RaGae.Game.Blocks.DataLib.Config;
using RaGae.Game.Blocks.DataLib.Converter;
using RaGae.Game.Blocks.DataLib.Score;
using RaGae.Game.Blocks.GameLib;
using RaGae.Game.Blocks.GameLib.Enumeration;
using RaGae.Game.Blocks.GameLib.Factory;
using RaGae.Game.Blocks.GameLib.Provider;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace RaGae.Game.Blocks.App
{
    public partial class FormMain : Form
    {
        private const int BRICK_SIZE = 20;
        private static Manager gameManager;
        private static StorageProvider gameStorage;
        private static Plot plotGraphics = new(BRICK_SIZE);
        private static SoundPlayer player = new SoundPlayer();

        public FormMain()
        {
            this.InitializeComponent();
            this.pictureBoxGame.BackColor = Program.PresentationConfig.Background;

            if (Program.LanguageConfig.Culture.Name.ToLower() == "de-DE".ToLower())
                this.germanToolStripMenuItem.Checked = true;
            else
                this.englishToolStripMenuItem.Checked = true;
#if !DEBUG
            this.groupBoxDebug.Visible = false;
#endif
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            gameManager = new Manager(
                GameFactory.Instance(
                    new Size(
                        (pictureBoxGame.Size.Width / plotGraphics.BrickSize),
                        (pictureBoxGame.Size.Height / plotGraphics.BrickSize))
                    ));

            gameManager.FieldChanged += Field_Action;
            gameManager.BrickChanged += Brick_Action;
            gameManager.ScoreChanged += Score_Action;
            gameManager.LevelChanged += Level_Action;
            gameManager.GameChanged += Game_Action;

            gameManager.Colors = Program.PresentationConfig.Blocks;
            gameManager.Level = 0;
            gameManager.New();

            player.SoundLocation = Path.Combine(Program.SoundConfig.Folder, Program.SoundConfig.Game);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            this.pictureBoxBrick.Invalidate();
        }

        private void FormMain_Deactivate(object sender, EventArgs e) => this.buttonPause_Click(sender, e);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left ||
                keyData == Keys.Right ||
                keyData == Keys.Down ||
                keyData == Keys.Pause)
            {
                this.FormMain_KeyDown(null, new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameManager.Status)
                return;

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
                    gameManager.Movement.Move(Direction.Left);
                    break;
                case Keys.Right:
                    gameManager.Movement.Move(Direction.Right);
                    break;
                case Keys.Down:
                    gameManager.Movement.Down();
                    break;
                case Keys.Space:
                    gameManager.Movement.Rotate(Rotation.Left);
                    break;
                case Keys.Pause:
                    this.buttonPause_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Game_Action(object sender)
        {
            this.PlaySound(Program.SoundConfig.GameOver);

            Program.ScoreBoard.Entries.Add(
                new ScoreEntry(
                    this.textBoxPlayer.Text,
                    gameManager.Score
                    ));

            this.Invoke(new Action(() =>
            {
                this.labelGameOver.Visible = true;
                this.buttonScoreBoard.Enabled = true;
                this.buttonScoreBoard.Visible = true;
                this.buttonPlay.Enabled = false;
                this.buttonPause.Enabled = false;
                this.saveToolStripMenuItem.Enabled = false;
            }));

            return;
        }

        private void Field_Action(object sender)
        {
#if DEBUG
            this.labelXValue.Invoke(new Action(() =>
            {
                this.labelXValue.Text = gameManager.Field.Current.Position.X.ToString();
            }));
            this.labelYValue.Invoke(new Action(() =>
            {
                this.labelYValue.Text = gameManager.Field.Current.Position.Y.ToString();
            }));
#endif

            this.pictureBoxGame.Invalidate();
        }

        private void Brick_Action(object sender)
        {
            this.pictureBoxBrick.Invalidate();
        }

        private void Score_Action(object sender)
        {
            bool megaLine = (bool)(sender);

            // Currently not working cause of soundplayer can only play one file at once
            //if (megaLine)
            //    this.PlaySound(Program.SoundConfig.MultiRow);

            this.labelScore.Invoke(new Action(() =>
            {
                this.labelScore.Text = gameManager.Score.ToString();
            }));
        }

        private void Level_Action(object sender)
        {
            this.comboBoxLevel.Invoke(new Action(() =>
            {
                this.comboBoxLevel.SelectedIndex = this.comboBoxLevel.Items.IndexOf($"{nameof(gameManager.Level)} {gameManager.Level}");
            }));
        }

        private void pictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)(sender);

            Graphics dev = e.Graphics;
            dev.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int start_x = pb.Width / 2 - plotGraphics.BrickSize * (pb.Width / (2 * plotGraphics.BrickSize));
            int start_y = pb.Height - 1;

            if (gameManager.Field.Current is null)
                return;

            // Draw Brick
            plotGraphics.Brick(
                dev,
                new Point(
                    start_x,
                    start_y),
                new Point(
                    gameManager.Field.Current.Position.X,
                    gameManager.Field.Current.Position.Y + gameManager.Field.Current.Brick.Apperance.GetLength(0) - 1),
                gameManager.Field.Current.Brick,
                gameManager.Field.Current.Color);

            // Draw Field
            for (int y = 0; y < gameManager.Field.Line.Count; y++)
            {
                for (int x = 0; x < gameManager.Field.Line.ElementAt(y).Length; x++)
                {
                    if (gameManager.Field.Line.ElementAt(y)[x] is not null)
                    {
                        plotGraphics.Block(
                            dev, gameManager.Field.Line.ElementAt(y)[x].Color,
                            new Point(
                                start_x + x * plotGraphics.BrickSize,
                                start_y - y * plotGraphics.BrickSize));
                    }
                }
            }
        }

        private void pictureBoxBrick_Paint(object sender, PaintEventArgs e)
        {
            FieldBrick b = gameManager.Field.Next;

            if (b is null)
                return;

            PictureBox pb = (PictureBox)(sender);
            Graphics dev = e.Graphics;

            plotGraphics.Brick(
                dev,
                new Point(
                    pb.Width / 2 - (int)((b.Brick.Apperance.GetLength(1) / 2.0) * plotGraphics.BrickSize),
                    pb.Height / 2),
                new Point(0, (int)((b.Brick.Apperance.GetLength(0) / 2.0 - 1))),
                b.Brick, b.Color);
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameManager.Level = int.Parse(this.comboBoxLevel.SelectedItem.ToString().Substring(6));
        }

        private void buttonScoreBoard_Click(object sender, EventArgs e)
        {
            Form form = new FormScoreBoard(Program.ScoreBoard);
            form.ShowDialog();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.buttonPlay.Enabled = false;
            this.buttonPause.Enabled = true;
            this.groupBoxSettings.Enabled = false;
            this.comboBoxLevel.Enabled = false;
            this.saveToolStripMenuItem.Enabled = true;

            gameManager.Start();

            if (checkBoxSound.Checked && File.Exists(player.SoundLocation))
                player.PlayLooping();
            else
                player.Stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (this.buttonPause.Enabled)
                this.PlaySound(Program.SoundConfig.Pause);

            this.buttonPlay.Enabled = true;
            this.buttonPause.Enabled = false;
            this.groupBoxSettings.Enabled = true;

            gameManager.Pause();
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Link.Open($"https://{((LinkLabel)(sender)).Text}");

        private void menuStripMain_Click(object sender, EventArgs e) => this.buttonPause_Click(sender, e);

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetForm();
            gameManager.New();
            this.comboBoxLevel.Enabled = true;
        }

        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e) => this.buttonScoreBoard_Click(sender, e);

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gameStorage is null)
                gameStorage = new FileStorageProvider();

            if(!gameStorage.Save(gameManager))
                MessageBox.Show(string.Format(Properties.StringResource.SavingDataError, nameof(Blocks)), Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show(gameStorage.ToString(), Properties.StringResource.GameSaved, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder fileBuilder = new StringBuilder();

            FormOpenGame form = new FormOpenGame(fileBuilder);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            gameStorage = new FileStorageProvider(fileBuilder.ToString());

            if(!gameStorage.Load(gameManager))
            {
                MessageBox.Show(string.Format(Properties.StringResource.LoadingDataError, nameof(Blocks)), Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                gameStorage = null;
                return;
            }

            this.ResetForm();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void handlingToolStripMenuItem_Click(object sender, EventArgs e) => new FormHandling(plotGraphics).ShowDialog();

        private void soundToolStripMenuItem_Click(object sender, EventArgs e) => new FormSound(player).ShowDialog();

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormColor(plotGraphics).ShowDialog();

            this.pictureBoxGame.BackColor = Program.PresentationConfig.Background;
            this.gridToolStripMenuItem.Checked = !this.gridToolStripMenuItem.Checked;
            this.gridToolStripMenuItem_Click(this.gridToolStripMenuItem, e);
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)(sender);

            if (item.Checked)
            {
                item.Checked = false;
                return;
            }
            item.Checked = true;
        }

        private void gridToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)(sender);

            if (item.Checked)
            {
                this.pictureBoxGame.Image = plotGraphics.Grid(pictureBoxGame.Size, Program.PresentationConfig.Grid);
                return;
            }

            this.pictureBoxGame.Image = null;
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)(sender);

            if (!item.Checked)
            {
                string language;

                if (item.Name == this.germanToolStripMenuItem.Name)
                    language = "de-DE".ToLower();
                else
                    language = "en-US".ToLower();

                Program.LanguageConfig.Culture = new CultureInfo(language);

                if (!DataService.Write(Path.Combine(nameof(Program.Config), $"{nameof(Language)}.json"), Program.LanguageConfig, new JsonSerializerOptions() { Converters = { new CultureJsonConverter() } }))
                {
                    MessageBox.Show(string.Format(Properties.StringResource.SavingDataError, nameof(Language)), Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if(MessageBox.Show(Properties.StringResource.LanguageRestart, Properties.StringResource.LanguageChanged, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e) => new FormFile(versionToolStripMenuItem.Text, "VERSION", Size.Empty).ShowDialog();

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e) => new FormFile(licenseToolStripMenuItem.Text, "LICENSE", new Size(640, 480)).ShowDialog();

        private void ResetForm()
        {
            this.buttonPlay.Enabled = true;
            this.buttonPause.Enabled = false;
            this.groupBoxSettings.Enabled = true;
            this.labelGameOver.Visible = false;
            this.comboBoxLevel.Enabled = false;
            this.buttonScoreBoard.Enabled = false;
            this.buttonScoreBoard.Visible = false;
        }

        private void PlaySound(string file)
        {
            if (checkBoxSound.Checked)
            {
                using (SoundPlayer p = new SoundPlayer())
                {
                    p.SoundLocation = Path.Combine(Program.SoundConfig.Folder, file);

                    if (File.Exists(p.SoundLocation))
                        p.Play();
                }
            }
        }
    }
}
