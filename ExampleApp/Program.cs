namespace ExampleApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
            ApplicationConfiguration.Initialize();
            Application.Run(new Form4p17());
        }

        private static void CurrentDomain_ProcessExit(object? sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}