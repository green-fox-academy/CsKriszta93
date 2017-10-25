using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using static BankOfSimba.Models.AnimalTypes;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("Simba")]
        
        // GET: /<controller>/
        public IActionResult Index()
        {     
            return View(bankAccount);
        }

        BankAccount bankAccount = new BankAccount()
        {
            Name = "Simba",
            Balance = 2000,
            AnimalType = AnimalType.Lion
        };
    }
}
