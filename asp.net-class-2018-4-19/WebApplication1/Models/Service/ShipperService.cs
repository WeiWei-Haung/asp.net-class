using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.Service
{
    public class ShipperService
    {
        public List<SelectListItem> GetShipperName()
        {
            List<SelectListItem> item = new List<SelectListItem>();
            foreach (Shippers i in NewShipper)
            {
                item.Add(new SelectListItem()
                {
                    Value = i.ShipperID.ToString(),
                    Text = i.CompanyName
                });


            }
            return item;
        }

        public static List<Shippers> NewShipper = new List<Shippers>()
        {
            new Shippers()
            {
                ShipperID=1,
                CompanyName="AA",
                Phone="0123456"
            },
            new Shippers()
            {
                ShipperID=2,
                CompanyName="BB",
                Phone="654321"
            }
        };
    }
}