using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyAirport.EF;
using System;
using System.Configuration;
using System.Linq;
using MyAirport.ConsoleApp;

namespace MyAirport.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var logger = MyAirportContext.loggerFactory.CreateLogger<Program>();
            
            //TODO : Faire marcher la création de l'objet MyAirportContext() avec DbContextOptions
            
            //DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder<MyAirportContext>();
           // var connectionString = ConfigurationManager.ConnectionStrings["MyAirportDatabase"].ConnectionString;
            //optionsBuilder.UseSqlServer(connectionString);

            System.Console.WriteLine("MyAirport project bonjour!!");
            //using (var db = new MyAirportContext(optionsBuilder.Options)
            using (var db = new MyAirportContext())
            {
                // Create
                Console.WriteLine("Création du vol LH1232");
                Vol v1 = new Vol
                {
                    Cie = "LH",
                    Destination = "BKK",
                    Dhc = Convert.ToDateTime("14/01/2020 16:45"),
                    Immatriculation = "RZ62",
                    Lig = "1232",
                    Parking = "R52",
                    NbPassagers = 238
                };
                db.Add(v1);

                Console.WriteLine("Creation vol SQ333");
                Vol v2 = new Vol
                {
                    Cie = "SK",
                    Destination = "CDG",
                    Dhc = Convert.ToDateTime("14/01/2020 18:20"),
                    Immatriculation = "TG43",
                    Lig = "333",
                    Parking = "R51",
                    NbPassagers = 423
                };
                db.Add(v2);

                Console.WriteLine("creation du bagage 012387364501");
                Bagage b1 = new Bagage
                {
                    Classe = "Y",
                    CodeIata = "012387364501",
                    DateCreation = Convert.ToDateTime("14/01/2020 12:52"),
                    Destination = "BEG"
                };
                db.Add(b1);

                db.SaveChanges();
                Console.ReadLine();
                
                //logger.LogInformation("Example log message create");

                // Read
                
                Console.WriteLine("Voici la liste des vols disponibles");
                var vol = db.Vols
                    .OrderBy(v => v.Cie);
                foreach (var v in vol)
                {
                    Console.WriteLine($"Le vol {v.Cie}{v.Lig} N° {v.VolId} a destination de {v.Destination} part à {v.Dhc} heure");
                }
                Console.ReadLine();

                // Update
                Console.WriteLine($"Le bagage {b1.BagageId} est modifié pour être rattaché au ");
                b1.VolId = v1.VolId;
                db.SaveChanges();
                Console.ReadLine();
               

                //Delete vol et bagages du vol
                Console.WriteLine($"Suppression du vol {v1.VolId} => {v1.Cie}{v1.Lig}");
                db.Remove(v1);
                db.SaveChanges();
                Console.ReadLine();
            }

         

        }
    }
}
