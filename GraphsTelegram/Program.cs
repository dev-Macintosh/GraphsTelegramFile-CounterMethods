namespace GraphsTelegram
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application_my.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}