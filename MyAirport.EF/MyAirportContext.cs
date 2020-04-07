using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Logging;

namespace MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public MyAirportContext(DbContextOptions options) : base(options)
        {

        }

        public MyAirportContext()
        {
        }

        public DbSet<Bagage>? Bagages { get; set; }
        public DbSet<Vol>? Vols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // var connectionString = ConfigurationManager.ConnectionStrings["MyAirportDatabase"].ConnectionString;
           // optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=MyAirport;Integrated Security=True;");
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        //1. Initialiser le loggerFactory
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });


    }
}
