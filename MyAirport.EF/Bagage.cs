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
        [Column(TypeName = "char(12)")]
        public string Classe { get; set; }
        [Column(TypeName = "char(12)")]
        public Byte Prioritaire { get; set; }

        public string Sta { get; set; }
        [Column(TypeName = "char(12)")]
        public string SSUR { get; set; }
        [Column(TypeName = "char(12)")]
        public string Destination { get; set; }
        [Column(TypeName = "char(12)")]
        public string Escale { get; set; }

        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }

        public Bagage()
        {

        }

    }
}
