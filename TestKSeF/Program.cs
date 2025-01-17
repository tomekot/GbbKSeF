namespace TestKSeF
{
    internal static class Program
    {

        public static Configuration Configuration { get; set; } = new();

        private static string GetConfigFileName()
        {
            return Path.Combine(GetConfigPath(), "config.xml");
        }

        public static string GetConfigPath()
        {
            string ret = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gbb Software");
            ret = Path.Combine(ret, "GbbKSeF");
            Directory.CreateDirectory(ret);
            return ret;
        }

        public static void SaveConfig()
        {
            Configuration.SaveConfig(GetConfigFileName());
        }

        public static void LoadConfig()
        {
            Configuration = Configuration.LoadConfig(GetConfigFileName());
        }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // upgrade user settings
            if (Properties.Settings.Default.UpgradeSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeSettings = false;
                Properties.Settings.Default.Save();
            }

            LoadConfig();

            Application.Run(new MainForm());
        }
    }
}