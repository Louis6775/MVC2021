using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc2021.Models;

namespace Mvc2021.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.customMessage = "This is a custom message";
            Product newProduct = new Product { productID = 1, ProductName = "Toy Plane", Description = "This is a Toy Plane" };
            return View(newProduct);
        }

        public IActionResult listing()
        {
            return View(GetProducts());
        }

        public IActionResult edit(int id)
        {
            Product findProduct = GetProducts().Where(x => x.productID == id).Single();
            //List<Product> findProducts = GetProducts().Where(x => x.ProductName.Contains("toy")).ToList();

            //Product findProduct = null;
            //foreach(Product p in GetProducts())
            //{
            //    if (p.productID == id)
            //    {
            //        findProduct = p;
            //        break;
            //    }
            //}

            ViewBag.myPageTitle = $"This is the edit page from a view bag {id}";
            return View(findProduct);
        }

        public IActionResult details()
        {
            return View();
        }
        public IActionResult delete()
        {
            return View();
        }

        private static List<Product> GetProducts()
        {

            Product newProduct = new Product { productID = 1, ProductName = "Toy Plane", Description = "This is a Toy Plane" };
            Product newProduct2 = new Product { productID = 2, ProductName = "Toy Boat", Description = "This is a Toy Boat" };

            List<Product> listOfproducts = new List<Product>();
            listOfproducts.Add(newProduct);
            listOfproducts.Add(newProduct2);

            return listOfproducts;
        }
    }
}