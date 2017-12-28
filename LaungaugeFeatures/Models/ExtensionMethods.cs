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

   
        public static IEnumerable<ProductVM> FilterByPrice(this IEnumerable<ProductVM> productEnum, decimal minimumPrice)
        {
            foreach(ProductVM prod in productEnum)
            {
                if((prod?.price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }

        public static IEnumerable<ProductVM> FilterByName(this IEnumerable<ProductVM> productEnum, char firstLetter)
        {
            foreach(ProductVM prod in productEnum)
            {
                if(prod?.name[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<ProductVM> Filter(
            this IEnumerable<ProductVM> productEnum,
            Func<ProductVM, bool> selector)
        {
            foreach(ProductVM prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }
      

        }
    }
