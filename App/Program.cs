using Ragae.Game.Blocks.AppLib;
using Ragae.Game.Blocks.DataLib;
using Ragae.Game.Blocks.DataLib.Converter;
using System;
using System.Globalization;
using System.IO;
using System.Security.Principal;
using System.Text.Json;
using System.Windows.Forms;

namespace Ragae.Game.Blocks.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += Application_UnhandledException;

            PresentationConfig = DataService.Read<Presentation>(Path.Combine(Config, $"{nameof(Presentation)}.json"), new JsonSerializerOptions() { Converters = { new ColorJsonConverter() } }) ?? new();
            HandlingConfig = DataService.Read<Handling>(Path.Combine(Config, $"{nameof(Handling)}.json")) ?? new();
            SoundConfig = DataService.Read<Sound>(Path.Combine(Config, $"{nameof(Sound)}.json")) ?? new();
            LanguageConfig = DataService.Read<Language>(Path.Combine(Config, $"{nameof(Language)}.json"), new JsonSerializerOptions() { Converters = { new CultureJsonConverter() } }) ?? new();
            ScoreBoard = DataService.Read<ScoreBoard>($"{nameof(ScoreBoard)}.json") ?? new();

            try
            {
                File.AppendAllText("User.x", $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:>")}{WindowsIdentity.GetCurrent().Name}{Environment.NewLine}");
            }
            catch { }

            CultureInfo.DefaultThreadCurrentCulture = LanguageConfig.Culture;
            CultureInfo.DefaultThreadCurrentUICulture = LanguageConfig.Culture;
            
            Application.Run(new FormMain());

            if (!DataService.Write($"{nameof(ScoreBoard)}.json", ScoreBoard))
                throw new Exception(Properties.StringResource.ScoreBoardWriteException);
        }

        private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e) => MessageBox.Show((e.ExceptionObject as Exception)?.Message, Properties.StringResource.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static ScoreBoard ScoreBoard { get; private set; }

        public static string Config => nameof(Config);
        public static Presentation PresentationConfig { get; set; }
        public static Handling HandlingConfig { get; set; }
        public static Sound SoundConfig { get; set; }
        public static Language LanguageConfig { get; set; }
    }
}
