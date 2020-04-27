using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAirport.EF
{
    /// <summary>
    /// Classe Vol, représente une instance de Vol
    /// </summary>
    public class Vol
    {
            /// <summary>
            /// Clé primaire de ma classe Vol
            /// </summary>
            [Key]
            public int VolId { get; set; }

            /// <summary>
            /// Compagnie du Vol
            /// </summary>
            public string Cie { get; set; }

            /// <summary>
            /// Numéro de ligne du vol
            /// </summary>
            public string Lig { get; set; }
            
            /// <summary>
            /// Dernier horaire connu
            /// </summary>
            public DateTime Dhc { get; set; }
            
            /// <summary>
            /// Parking affecté au vol
            /// </summary>
            public string? Parking { get; set; }

            /// <summary>
            /// Numéro d'immatriculation de l'avion
            /// </summary>
            public string? Immatriculation { get; set; }
            
            /// <summary>
            /// Nombre de passagers du vol
            /// </summary>
            public short? NbPassagers { get; set; }

            /// <summary>
            /// Ville de destination finale du vol
            /// </summary>
            public string? Destination { get; set; }
        
            public IEnumerable<Bagage>? Bagages { get; set; }

        /// <summary>
        /// Constructeur d'une instance Vol
        /// </summary>
        public Vol()
        {

        }

        /// <summary>
        /// Constructeur d'une instance Vol
        /// </summary>
        /// <param name="compagnie"></param>
        /// <param name="ligne"></param>
        /// <param name="dhc"></param>
        public Vol(string compagnie, string ligne, DateTime dhc)
        {
            Cie = compagnie;
            Lig = ligne;
            Dhc = dhc;
            // Bagages = null;//new List<Bagage>();

        }

    }
}
