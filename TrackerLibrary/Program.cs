using Microsoft.VisualBasic.ApplicationServices;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalConfig.InitializeConnection();

            if (GlobalConfig.Connection == null)
            {
                MessageBox.Show("Database connection is not initialized.");
                return;
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
            ApplicationConfiguration.Initialize();

            //Application.Run(new goals_form(user));

            //Application.Run(new goals_form(user));
            SqlConnector.ClearDatabase();
            Application.Run(new CreateUserForm());
        }
    }
}