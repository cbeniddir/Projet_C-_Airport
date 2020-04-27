using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAirport.EF
{
    /// <summary>
    /// Classe Bagage, représente une instance de Bagage
    /// </summary>
    public class Bagage
    {
        /// <summary>
        /// Clé primaire de l'objet Bagage
        /// </summary>
        [Key]
        public int BagageId { get; set; }

        /// <summary>
        /// Objet vol permettant d'associer les classes Vol et Bagage
        /// Propriété de navigation
        /// </summary>
        public virtual Vol? Vol { get; set; }

        /// <summary>
        /// Clé étrangère représentant l'id du vol associé au Bagage
        /// </summary>
        [ForeignKey("VolId")]
        public int? VolId { get; set; }
        /// <summary>
        /// Date de création du Bagage
        /// </summary>
        public DateTime DateCreation { get; set; }
        /// <summary>
        /// CodeIata du Bagage
        /// </summary>
        
        [StringLength(16)]
        [Display(Name = "Code IATA")]
        public string CodeIata { get; set; }
        /// <summary>
        /// Classe du Bagage
        /// </summary>
        [Column(TypeName = "char(12)")]
        public string Classe { get; set; }
        /// <summary>
        /// Priorité du bagage
        /// </summary>
        [Column(TypeName = "char(12)")]
        public Byte Prioritaire { get; set; }
        /// <summary>
        /// Sta du Bagage
        /// </summary>
        public string Sta { get; set; }
        /// <summary>
        /// SSUR du bagage
        /// </summary>
        [Column(TypeName = "char(12)")]
        public string SSUR { get; set; }
        /// <summary>
        /// Destination du bagage
        /// </summary>
        [Column(TypeName = "char(12)")]
        public string Destination { get; set; }
        /// <summary>
        /// Escale du bagage
        /// </summary>
        [Column(TypeName = "char(12)")]
        public string Escale { get; set; }
        /// <summary>
        /// Constructeur de l'instance bagage par codeIata et sa date de création
        /// </summary>
        /// <param name="codeIata"></param>
        /// <param name="dateCreation"></param>
        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }
        /// <summary>
        /// Constructeur de l'objet Bagage
        /// Donne la possibilité de construire un objet Bagage sans passer de paramètres
        /// </summary>
        public Bagage()
        {

        }

    }
}
