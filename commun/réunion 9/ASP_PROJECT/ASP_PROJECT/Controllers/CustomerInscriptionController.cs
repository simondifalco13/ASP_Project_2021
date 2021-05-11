using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PROJECT.Controllers {
    public class CustomerInscriptionController : Controller {
        public IActionResult Index() {
            return View("Views/Home/CustomerInscrption.cshtml");
        }
    }
}