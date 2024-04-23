using NLog.Config;
using NLog;

namespace HeartFluttering.Classes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("../../../../HeartFluttering/NLog.config");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthorizationForm());
        }
    }
}