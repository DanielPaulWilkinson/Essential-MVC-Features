using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaungaugeFeatures.Models
{

    //implimented interface 11:45
    public class ShoppingCartVM : IEnumerable<ProductVM>
    {
        public IEnumerable<ProductVM> Products {get; set;}

         public IEnumerator<ProductVM> GetEnumerator()
        {
            return Products.GetEnumerator();
                }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
