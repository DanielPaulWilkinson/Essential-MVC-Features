using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaungaugeFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaungaugeFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            #region 1) Adding values when values are missing.
            //List<String> res = new List<string>();
            //foreach (ProductVM p in ProductVM.getProduct())
            //{
            //    string name = p?.name ?? "<No Name>";
            //    decimal? price = p?.price ?? 0;
            //    string Related = p?.Related?.name ?? "<None>";
            //    res.Add($"The product is a {name} with a price of {price}. related: {Related}");
            //    TempData["NULLABLE "] = res;
            //}
            #endregion

            #region 2) Indexing with syntax sugar
            //Dictionary<string, ProductVM> products = new Dictionary<string, ProductVM>
            //{
            //    ["kayak"] = new ProductVM { name = "kayak", price = 213 },
            //    ["bike"] = new ProductVM { name = "bike", price = 100 },
            //    ["car"] = new ProductVM { name = "car", price = 200 },
            //    ["boat"] = new ProductVM { name = "boat", price = 345 }
            //};

            #endregion

            #region 3) Pattern matching basic
            //object[] data = new object[] { 125m, 29.95m, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}

            //TempData["TOTAL"] = new string[] { $"Total: {total:C2}" };

            #endregion

            #region 4) Pattern matching in switch statments
            //total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal DecValue:
            //            total += DecValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }

            //}
            #endregion

            #region 5) Extension Methods - filter by name, price & general filter.

            //ShoppingCartVM cart = new ShoppingCartVM { Products = ProductVM.getProduct() };

            //ProductVM[] ProductArray =
            //{
            //    new ProductVM{name="Kayak",price=1},
            //    new ProductVM{name="Bike",price=2},
            //    new ProductVM{name="Car",price=789},
            //    new ProductVM{name="Boat",price=8},
            //    new ProductVM{name="plane",price=100},
            //    new ProductVM{name="train",price=20000},
            //    new ProductVM{name="submarine",price=39},
            //};
            //decimal carttotal = cart.TotalPrices();
            //decimal arraytotal = ProductArray.TotalPrices();
            //TempData["TotalPrices"] = new String[] { $" Cart Total: {carttotal:C2}", $"Array Total: {arraytotal:C2}" };

            ////filter by price.
            //decimal arrayTotal = ProductArray.FilterByPrice(30).TotalPrices();
            //TempData["TotalPrices"] = new String[] { $" Cart Total: {carttotal:C2}", $"Array Total: {arraytotal:C2}" };


            ////filter by name.
            //decimal nameFilterTotal = ProductArray.FilterByName('b').TotalPrices();
            //TempData["TotalNamePrices"] = new String[] { $"Name Filter Total: {nameFilterTotal:C2}" };

            #endregion

            #region 6) Lambina Expressions

            ////class to filter by price
            //bool FilterByPrice(ProductVM p)
            //{
            //    return (p?.price ?? 0) >= 20;
            //}


            ////filter name
            //Func<ProductVM, bool> nameFilter = delegate (ProductVM prod)
            //{
            //    return prod?.name?[0] == 's';
            //};

            //decimal priceFilterTotal2 = ProductArray
            //    .Filter(p => (p?.price ?? 0) >= 20)
            //    .TotalPrices();
            //decimal nameFilterTotal2 = ProductArray
            //    .Filter(p => p?.name?[0] == 's')
            //    .TotalPrices();



            ////using inference and anonymous types
            ////var Names = new[] {"Kyak","Bike","Car"};
            ////return View(Names);

            //var productss = new[]
            //{
            //    new { name = "Kyak", price = 1},
            //    new { name = "Bike", price = 200},
            //    new { name = "Car", price = 23123},
            //    new { name = "Boat", price = 2355443},
            //};
            //// return View(productss.Select(p => p?.name));

            #endregion

            #region 7) sync Methods
            //async method
            //long? result = await AsyncMethods.GetPageLength();
            //return View($"page langth: {result}");

            // return View(new String[] { $"Result: {result}" });
            #endregion

            #region 8) References to names of methods, classes & variables
            //var products_list =  new [] {

            //    new { name= "kyak", price=1},
            //    new { name= "car", price=200},
            //    new { name= "bike", price=40},

            //};

            //return View(products_list.Select(p => $"Name: {p.name}, Price: {p.price}"));
            //return View(products_list.Select(p=>
            //$"{nameof(p.name)},{nameof(p.price)}"));

            #endregion

            return View();

        }

        // public ActionResult Index1() => View(ProductVM.getProduct().Select(P => P.name[0] == 'B'));
        
    }
}