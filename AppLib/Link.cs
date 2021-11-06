using System.Diagnostics;

namespace RaGae.Game.Blocks.AppLib
{
    public static class Link
    {
        public static bool Open(string url)
        {
            try
            {
                Process.Start("cmd", "/C start" + " " + url);
                return true;
            }
            catch { }

            return false;
        }
    }
}
