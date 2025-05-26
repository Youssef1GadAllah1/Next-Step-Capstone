using Capstone_Next_Step.Data;
using Capstone_Next_Step.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Capstone_Next_Step.Controllers
{
    public class AssetController : Controller
    {
        private AppDbContext _context;
        public AssetController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IActionResult Index()
        {
            var ProdectList = _context.Assets.ToList();
            return View(ProdectList);
        }

        public IActionResult AddAsset()
        {
            return View();
        }
        public IActionResult AddAssetsForm(Asset asset)
        {
            _context.Assets.Add(asset);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult AddProductForm(Product Products)
        {
            _context.Products.Add(Products);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Inventory()
        {
            var Inventory = _context.Products.ToList();
            return View(Inventory);
        }


      
    }
}
