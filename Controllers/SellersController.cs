using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartamentsService _departamentsService;

        public SellersController(SellerService sellerService, DepartamentsService departamentsService)
        {
            _sellerService = sellerService;
            _departamentsService = departamentsService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {

            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
        
    }
}