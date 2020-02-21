using System;

namespace MyAirport.EF
{
    public class Bagage
    {
        private int Id { get; set; }
        private DateTime Date_Creation { get; set; }
        private string Code_Iata { get; set; }
        private string Classe { get; set; }
        private string Prioritaire { get; set; }
        private string Sta { get; set; }
        private string SSUR { get; set; }
        private string Destination { get; set; }
        private string Escale { get; set; }

    }
}
