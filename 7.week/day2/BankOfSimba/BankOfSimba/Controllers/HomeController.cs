using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using static BankOfSimba.Models.AnimalTypes;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("Simba")]
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

        [Route("Characters")]
        public IActionResult Bank()
        {
            Bank bank = new Bank();

            BankAccount bankAccount2 = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = AnimalType.Lion
            };
            bank.bankAccounts.Add(bankAccount2);

            BankAccount bankAccount3 = new BankAccount()
            {
                Name = "Timon",
                Balance = 1000,
                AnimalType = AnimalType.Meerkat
            };
            bank.bankAccounts.Add(bankAccount3);

            BankAccount bankAccount4 = new BankAccount()
            {
                Name = "Pumba",
                Balance = 100,
                AnimalType = AnimalType.Warthog
            };
            bank.bankAccounts.Add(bankAccount4);

            BankAccount bankAccount5 = new BankAccount()
            {
                Name = "Zazu",
                Balance = 3000,
                AnimalType = AnimalType.Hornbill
            };
            bank.bankAccounts.Add(bankAccount5);

            BankAccount bankAccount6 = new BankAccount()
            {
                Name = "Rafiki",
                Balance = 100000,
                AnimalType = AnimalType.Mandrill
            };
            bank.bankAccounts.Add(bankAccount6);

            return View(bank.bankAccounts);
        }
    }
}
