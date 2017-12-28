using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaungaugeFeatures.Models
{
        /*  
        Book Page: Page 85
        Name: Creating extention methods of a class if we cannot modify the class directly
        Who: (28/12/17 - DW)
        */
    public static class ExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<ProductVM> product)
        {
            decimal decimaltotal = 0; 
            foreach(ProductVM p in product)
            {
                decimaltotal += p?.price ?? 0;
            }
            return decimaltotal;
        }
    }
}
