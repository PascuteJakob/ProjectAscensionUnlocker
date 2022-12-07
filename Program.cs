namespace ProjectAscensionUnlocker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 form = new Form1();
            Application.Run(form);
            form.logBox_LogText("eat my fat cock c#");
            Application.Update();
        }
    }
}