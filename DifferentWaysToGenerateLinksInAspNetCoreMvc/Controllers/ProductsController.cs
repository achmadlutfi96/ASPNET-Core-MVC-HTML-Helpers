using DifferentWaysToGenerateLinksInAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DifferentWaysToGenerateLinksInAspNetCoreMvc.Controllers
{
    public class ProductsController : Controller
    {
        // Static list of products, initialized with three products. 
        // This simulates an in-memory database of products.
        private static readonly List<Product> _products = new List<Product>
        {
            // Defining individual Product objects with properties such as Id, Name, Description, Category, Price, and Quantity.
            new Product { Id = 1, Name = "Laptop", Description = "A powerful laptop.", Category = "Electronics", Price = 1200.00m, Quantity = 10 },
            new Product { Id = 2, Name = "Smartphone", Description = "A high-end smartphone.", Category = "Electronics", Price = 800.00m, Quantity = 20 },
            new Product { Id = 3, Name = "Desktop", Description = "A Performance Desktop", Category = "Electronics", Price = 1000.00m, Quantity = 15 }
        };
        // This action method handles requests to the "List" action in the controller.
        // It returns a view displaying the list of products by passing the _products list to the view.
        public IActionResult List()
        {
            // Return the 'List' view and pass the _products collection to it for rendering.
            return View(_products);
        }
        // This action method handles requests to the "Details" action in the controller.
        // It accepts an 'id' parameter that is used to identify and retrieve a specific product.
        public IActionResult Details(int id)
        {
            // Using the List.Find method to search the _products list for a product with the matching Id.
            var product = _products.Find(p => p.Id == id);
            // Return the 'Details' view and pass the selected product to it for rendering.
            return View(product);
        }
    }
}
