using System;
using System.Configuration;
using FluentMigrator.Console;

namespace RH.DB.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string assembly = "--a=RH.DB.Migration.dll";
                string db = "--db=SqlServer";
                string conn = String.Format("--conn={0}", ConfigurationManager.ConnectionStrings["RemoteHiking"]);
                string profile = "--profile=Debug";
                args = new[] { assembly, db, conn, profile };

                new MigratorConsole(args);
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
