namespace RaGae.Game.Blocks.DataLib.Score
{
    public class ScoreEntry
    {
        public ScoreEntry() { }
        public ScoreEntry(string name, int score)
        {
            if (!string.IsNullOrWhiteSpace(name))
                this.Name = name;

            this.Score = score;
            this.Checksum = ScoreBoard.CreateChecksum(this);
        }

        public string Name { get; set; } = "NoName";
        public int Score { get; set; }
        public string Checksum { get; set; }
    }
}
