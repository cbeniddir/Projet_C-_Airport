using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAirport.EF
{
    public class Bagage
    {
        [Key]
        public int BagageId { get; set; }

        public Vol Vol { get; set; }

        [ForeignKey("VolId")]
        public int? VolId { get; set; }

        public DateTime DateCreation { get; set; }

        public string CodeIata { get; set; }

        public string Classe { get; set; }

        public string Prioritaire { get; set; }

        public string Sta { get; set; }

        public string SSUR { get; set; }

        public string Destination { get; set; }

        public string Escale { get; set; }

    }
}
