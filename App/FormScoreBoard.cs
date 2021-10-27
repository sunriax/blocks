using Ragae.Game.Blocks.AppLib;
using System.Linq;
using System.Windows.Forms;

namespace Ragae.Game.Blocks.App
{
    public partial class FormScoreBoard : Form
    {
        public FormScoreBoard(ScoreBoard scoreBoard)
        {
            this.InitializeComponent();
            this.dataGridViewBoard.DataSource = scoreBoard.Entries.Where(entry => ScoreBoard.ValidateChecksum(entry)).OrderByDescending(x => x.Score).ToList();
            this.dataGridViewBoard.Columns[nameof(ScoreEntry.Checksum)].Visible = false;
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            Program.ScoreBoard.Clear();
            this.Close();
        }
    }
}
