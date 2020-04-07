using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAirport.EF
{
    public class Vol
    {
            [Key]
            public int VolId { get; set; }

            public string Cie { get; set; }

            public string Lig { get; set; }

            public DateTime Dhc { get; set; }

            public string? Parking { get; set; }

            public string? Immatriculation { get; set; }

            public short? NbPassagers { get; set; }

            public string? Destination { get; set; }
            public IEnumerable<Bagage>? Bagages { get; set; }

            public Vol()
            {
                
            }

            public Vol(string compagnie, string ligne, DateTime dhc)
            {
                Cie = compagnie;
                Lig = ligne;
                Dhc = dhc;
               // Bagages = null;//new List<Bagage>();

            }

    }
}
