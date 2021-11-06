using System;

namespace RaGae.Game.Blocks.DataLib.Config
{
    public class Handling
    {
        private char right = 'd';
        private char left = 'a';
        private char down = 's';
        private char rotate = 'w';
        private char pause = 'p';

        public char Right { get => char.ToUpper(this.right); set => this.right = CheckCharacter(value) ? this.right = value : throw new ArgumentException($"{nameof(Handling)}:{nameof(Right)}"); }
        public char Left { get => char.ToUpper(this.left); set => this.left = CheckCharacter(value) ? this.left = value : throw new ArgumentException($"{nameof(Handling)}:{nameof(Left)}"); }
        public char Down { get => char.ToUpper(this.down); set => this.down = CheckCharacter(value) ? this.down = value : throw new ArgumentException($"{nameof(Handling)}:{nameof(Down)}"); }
        public char Rotate { get => char.ToUpper(this.rotate); set => this.rotate = CheckCharacter(value) ? this.rotate = value : throw new ArgumentException($"{nameof(Handling)}:{nameof(Rotate)}"); }
        public char Pause { get => char.ToUpper(this.pause); set => this.pause = CheckCharacter(value) ? this.pause = value : throw new ArgumentException($"{nameof(Handling)}:{nameof(Pause)}"); }

        public static bool CheckCharacter(char value)
        {
            if (char.IsWhiteSpace(value) || !char.IsLetter(value))
                return false;
            return true;
        }
    }
}
