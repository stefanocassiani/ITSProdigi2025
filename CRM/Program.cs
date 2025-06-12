<<<<<<< HEAD
using CRM.Strutture;

namespace CRM
{
    internal static class Program
    {
        public static Archivio db;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            File.Copy(
                "archivio.sqlite",
                Path.Combine("backups", DateTime.Now.ToShortDateString() + ".sqlite")
            );

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            db = new Archivio();
            Application.Run(new Form1(
                db                
            ));

        }
    }
}
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> f4444b0615e9aedc4414dd1a6ee7d4e8953989d4
