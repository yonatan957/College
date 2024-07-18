using College.DAL.Repositries;
using College.forms;
using Microsoft.Extensions.Configuration;
using ShabatGuest.BL;
using ShabatGuest.DAL;

namespace College
{
    internal class Program
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
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            string Conn = config["connectionstring"];
            DBconnections dBconnections = new DBconnections(Conn);
            CoursRepository coursRepository = new CoursRepository(dBconnections);
            StudentRepository studentRepository = new StudentRepository(dBconnections);
            NavigationService navigationService = new NavigationService(dBconnections,studentRepository, coursRepository);
            navigationService.ShowForm("LogIn");
            Application.Run();
        }
    }
}