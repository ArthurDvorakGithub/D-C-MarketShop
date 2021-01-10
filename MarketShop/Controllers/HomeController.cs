using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketShop.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController (DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
