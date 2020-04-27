using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAirportGraphQL.GraphQLType
{
    public class VolType : ObjectGraphType<MyAirport.EF.Vol>
    {
        public VolType()
        {
            Field(x => x.Cie);
            Field(x => x.Destination);
            Field(x => x.Dhc);
            Field(x => x.Immatriculation);
            Field(x => x.Lig);
            Field(x => x.NbPassagers);
            Field(x => x.Parking);
            Field(x => x.VolId);

        }
    
    }
}
