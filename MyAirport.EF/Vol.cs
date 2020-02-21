using System;
using System.ComponentModel.DataAnnotations;

namespace MyAirport.EF
{
    public class Vol
    {
            [Key]
            public int VolId { get; set; }

            public int Cie { get; set; }

            public string Lig { get; set; }

            public int Jex { get; set; }

            public DateTime Dhc { get; set; }

            public string Pkg { get; set; }

            public string Imm { get; set; }

            public int Pax { get; set; }

            public string Des { get; set; }
        
    }
}
