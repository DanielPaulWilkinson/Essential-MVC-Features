using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LaungaugeFeatures.Models
{
    public class ProductVM

    {
        //initalized to true but value can be changed
        public ProductVM(bool stock = true)
        {
            inStock = stock;
        }


        public string name {get; set;}
        public decimal? price { get; set; }
        //created property 27/12/17 22:54pm - previously set value which can be changed at run time.
        public string Category { get; set; } = "Watersports";
        //created property 27/12/17 22.00pm - links to other products.
        public ProductVM Related { get; set; }
        //created property 27/12/17 22.56pm - read only value.
        public bool inStock { get; } = true;

        public static ProductVM[] getProduct()
        {
            ProductVM car = new ProductVM(true)
            {
                name = "car",
                Category = "Water Craft",
                price = 250
            };
            ProductVM Bike = new ProductVM(false)
            {
                name = "bike",
                price = 50
            };

            car.Related = Bike; 

            return new ProductVM[] { car, Bike, null };
        }

    }
}
