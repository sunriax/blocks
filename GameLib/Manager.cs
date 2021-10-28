using Ragae.Game.Blocks.GameLib.Factory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Timers;

namespace Ragae.Game.Blocks.GameLib
{

    public class Manager : IDisposable
    {
        private event Invalidate Changed;
        public event Invalidate FieldChanged
        {
            add
            {
                this.Changed += value;
                this.Movement.Update += value;
            }
            remove
            {
                this.Changed += value;
                this.Movement.Update -= value;
            }
        }
        public event Invalidate BrickChanged;
        public event Invalidate ScoreChanged;
        public event Invalidate LevelChanged;
        public event Invalidate GameChanged;

        private static GameFactory gameFactory;

        private Timer timer = new Timer();
        private List<Color> colors;

        private int level;
        private int score;

        public Manager(GameFactory factory)
        {
            gameFactory = factory ?? throw new NullReferenceException($"{nameof(GameFactory)}:{nameof(factory)}");

            this.Field = factory.CreateField();
            this.Movement = factory.CreateMovement(Field);

            this.timer.Elapsed += Timer_Tick;
        }

        private void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            if (this.GameEnd)
            {
                this.Pause();
                this.GameChanged?.Invoke(this);
            }

            if (!this.Movement.Down())
            {
                // End reached
                // Move data to field
                this.Field.Brick2Field();

                if (this.Field.FullLines().Count() > 0)
                {
                    bool megaLine = false;

                    // Check if there are 4-Lines in common
                    if (this.Field.MegaLine())
                        megaLine = true;

                    this.Score += (this.Level + 1) * this.Field.Size.Width * (megaLine ? 4 * 10 : this.Field.FullLines().Count());

                    // Remove FullLines
                    this.Field.FullLines().ToList().ForEach(x => this.Field.Line.Remove(x));

                    // Update Score
                    this.ScoreChanged?.Invoke(megaLine);
                }

                // New Blocks
                this.Field.Current = this.Field.Next;
                this.Field.Next = gameFactory.CreateFieldBrick(this.RandomColor());

                this.Changed?.Invoke(this);
                this.BrickChanged?.Invoke(this);
            }
        }

        public int Level
        {
            get => this.level;
            set
            {
                if (value < 0 || value > 9)
                    throw new NullReferenceException(nameof(Score));

                this.level = value;
                this.timer.Interval = 1000 - (75 * this.level);
                this.LevelChanged?.Invoke(this);
            }
        }

        public int Score
        {
            get => this.score;
            private set
            {
                this.score = value;

                int nextLevel = this.Level;
                nextLevel = value switch
                {
                    var n when n >= 9000 => 9,
                    var n when n >= 8000 => 8,
                    var n when n >= 7000 => 7,
                    var n when n >= 6000 => 6,
                    var n when n >= 5000 => 5,
                    var n when n >= 4000 => 4,
                    var n when n >= 3000 => 3,
                    var n when n >= 2000 => 2,
                    var n when n >= 1000 => 1,
                    _ => 0
                };

                if (nextLevel > this.Level)
                    this.Level = nextLevel;
            }
        }

        public Field Field { get; private set; }

        public Movement Movement { get; private set; }

        public IEnumerable<Color> Colors
        {
            get => this.colors;
            set
            {
                if(value is null || value.Count() < 1)
                    throw new NullReferenceException($"{nameof(Manager)}:{nameof(Color)}");

                this.colors = value.ToList();
            }
        }

        public bool Status => this.timer?.Enabled ?? false;

        public void New()
        {
            this.Pause();
            
            this.Field.Current = gameFactory.CreateFieldBrick(this.RandomColor());
            this.Field.Next = gameFactory.CreateFieldBrick(this.RandomColor());

            this.Field.Line.Clear();

            this.Changed?.Invoke(this);
            this.BrickChanged?.Invoke(this);
            this.ScoreChanged?.Invoke(false);
            this.LevelChanged?.Invoke(false);
        }

        public void Load(Field field, int level = 0, int score = 0)
        {
            this.Pause();

            //this.Field.Current = gameFactory.CreateFieldBrick(this.RandomColor());
            //this.Field.Next = gameFactory.CreateFieldBrick(this.RandomColor());

            this.Field = field;
            this.Movement.Field = field;

            this.Level = level;
            this.Score = score;

            this.Changed?.Invoke(this);
            this.BrickChanged?.Invoke(this);
            this.ScoreChanged?.Invoke(false);
            this.LevelChanged?.Invoke(false);
        }

        public void Start()
        {
            if (this.GameEnd)
                return;

            this.timer.Start();
            this.BrickChanged?.Invoke(this);
        }

        public void Pause() => this.timer.Stop();

        public bool GameEnd => this.Field.Line.Count > (this.Field.Size.Height + 1) ? true : false;

        private Color RandomColor() => this.colors.ElementAt(RandomNumberGenerator.GetInt32(this.colors.Count));

        public void Dispose()
        {
            this.Field = null;
            this.Movement = null;

            this.timer?.Stop();
            this.timer?.Dispose();
        }
    }
}
