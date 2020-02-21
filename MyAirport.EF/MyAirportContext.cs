using System;
using Microsoft.EntityFrameworkCore;

namespace MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
       
       public DbSet<Bagage> Bagage { get; set; }
       public DbSet<Vol> Vol { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       { 
               optionsBuilder.UseSqlite("Data Source = MyAirport.db");
       }

    }
}
