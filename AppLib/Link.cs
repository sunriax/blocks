namespace Ragae.Game.Blocks.AppLib
{
    public static class Link
    {
        public static bool Open(string url)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd", "/C start" + " " + url);
                return true;
            }
            catch { }

            return false;
        }
    }
}
