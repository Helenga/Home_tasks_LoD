using System;
using System.Windows.Forms;
using System.IO;


namespace EnglishTrainerApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            initializeFiles();
        }

        private static void initializeFiles()
        {
            Directory.CreateDirectory(rootDirectoryApp);
            Directory.CreateDirectory(rootDirectoryApp + $"/Dictionaries");
            File.Create(rootDirectoryApp + $"/learnedWords.json");
            File.Create(rootDirectoryApp + $"/wordsOnLearning.json");
            File.Create(rootDirectoryApp + $"/users.json");
        }

        private static string rootDirectoryApp = "Repository";
    }
}
