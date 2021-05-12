using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountDAL _accountDAL;

        public AccountController(IAccountDAL accountDAL)
        {
            _accountDAL = accountDAL;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RestorerRegister()
        {
            Restorer r = new Restorer();
            return View("RestorerInscription", r);
        }

        [HttpPost]
        public IActionResult Register(Restorer r)
        {
            //pb
            if (ModelState.IsValid)
            {
                bool success = Restorer.Register(_accountDAL,r);
                return View("Index");
            }
            return View("RestorerInscription", r);

        }
    }
}
