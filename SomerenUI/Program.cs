using System;
using System.Windows.Forms;

namespace SomerenUI
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
            // see https://aka.ms/applicationconfiguration. //test push
            ApplicationConfiguration.Initialize();          //testing
            Application.Run(new SomerenUI());
        }
    }
}