using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using MigSharp;

namespace MigrationRunner
{
    class Program
    {
        private static IConfigurationRoot Configuration { get; set; }


        private static string AssemblyPath { get { return Configuration["Migrations:AssemblyPath"]; } }
        private static string ConnectionString { get { return Configuration["connectionString"]; } }
        // TODO: YOLO fix this 
        private static DbPlatform Platform { get { return   Enum.Parse(typeof(DbPlatform), Configuration["Platform"]) as DbPlatform; } }

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            Console.WriteLine($"connectionString = {Configuration["connectionString"]}");
            Console.WriteLine($"Platform = {Configuration["Platform"]}");
            Console.WriteLine($"Migrations:AssemblyPath = {Configuration["Migrations:AssemblyPath"]}");
            
            var migrator = new Migrator(ConnectionString, DbPlatform.SqlServer2016);
            var assemblyLoaded = Assembly.LoadFile(AssemblyPath); 
            migrator.MigrateAll(assemblyLoaded);

        }
    }
}
