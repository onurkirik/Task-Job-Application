using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task.Models;
using Task.Domain;

namespace Task.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        private static List<Product> allProducts = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Title = "First Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },
            new Product()
            {
                Id = 2,
                Title = "Second Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },
            new Product()
            {
                Id = 3,
                Title = "Third Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },
            new Product()
            {
                Id = 4,
                Title = "Fourth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 5,
                Title = "Fifth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 6,
                Title = "Sixth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 7,
                Title = "Seventh Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 8,
                Title = "Eighth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 9,
                Title = "Ninth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 10,
                Title = "Tenth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 11,
                Title = "Eleventh Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            },new Product()
            {
                Id = 12,
                Title = "Twelfth Product",
                ImageUrl = "https://cdn.cimri.io/image/1200x1200/enucuzofismasastbilgisayarfiyatlarvemodellericimricom_499605766.jpg"
            }
        };

        public IActionResult Index([FromQuery]string query = "")
        {
            var model = new SearchViewModel()
            {
                Query = query,
                Products = allProducts.Where(p => p.Title.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList()
            };
            return View(model);
        }
    }
}