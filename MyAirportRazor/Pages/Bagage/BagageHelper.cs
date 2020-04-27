using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAirportRazor.Pages.Bagage
{
    public class BagageHelper
    {
        public static SelectList ListVolInfos(MyAirport.EF.MyAirportContext context)
        {
            var vols = context.Vols
                .Select(v => new
                {
                    v.VolId,
                    Description = $"{v.Cie} {v.Lig} : {v.Dhc.ToShortDateString()}"
                }).ToList();
            //  ViewData["VolId"] = new SelectList(vols, "VolId", "Description");
            return new SelectList(vols, "VolId", "Description");
        }
    }
}
