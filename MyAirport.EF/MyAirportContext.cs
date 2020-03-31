using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Logging;

namespace MyAirport.EF
{
    public class MyAirportContext : DbContext
    {

        //public MyAirportContext(DbContextOptions options) : base(options)
        //{

        //}

        public DbSet<Bagage> Bagage { get; set; }
        public DbSet<Vol> Vol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // var connectionString = ConfigurationManager.ConnectionStrings["MyAirportDatabase"].ConnectionString;
           // optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=MyAirport;Integrated Security=True;");

        }

        //1. Initialiser le loggerFactory
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });


    }
}
