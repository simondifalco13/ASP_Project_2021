using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.POCO;
using ASP_PROJECT.ViewModels;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index() {
            return View();
        }


        public IActionResult RestorerRegister()
        {
            Restorer r = new Restorer();
            return View("RestorerInscription", r);
        }

        [HttpPost]
        public IActionResult RestorerRegister(Restorer r)
        {
            if (ModelState.IsValid)
            {
                //pb dans register
                bool success = Restorer.Register(_accountDAL, r);
                if (success == true)
                {
                    TempData["RegisterSuccess"] = "Vous avez créer un compte de restorateur avec succès";
                    return View("Index");
                }
                else
                {
                    TempData["Error"] = "An account with this email adress already exists !";
                    return View("RestorerInscription", r);
                }
            }
            else
            {
                return View("RestorerInscription", r);
            }
        }
        public IActionResult CustomerInscription() {
            return View();
        }
        /// À la création du comtpe, considérons la personne connectée -> Va pouvoir consulter les menus ( à modifier plus tard on verra )
        /// Si pas bon, retourner au formulaire d'inscription.
        /// Préciser HttpPost !!
        [HttpPost]
        public IActionResult CustomerRegister(Customer accountC) {
            // Il est possible de bypasser la vérification dynamique donc double vérification.
            if (ModelState.IsValid) {
                // -> Model -> DAL -> DB
                bool success = Customer.Register(_accountDAL, accountC);
                if (success == true) {
                    TempData["Message"] = "State0";
                    return View("CustomerInscription", accountC);
                } else {
                    TempData["Message"] = "State1";
                }
            } 
            return View("CustomerInscription");
        }

        public IActionResult Login() {
            //envoyer un viewmodel avec 2 objets de type restorer et customer, leur passer les données au 2 mais dans la DAL verifier que c'est le bon qu'on renvoit 
            LoginViewModel vm = new LoginViewModel();
            return View("Login",vm);
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel vm)
        {
            //verifier si le mail est un custommer ou restorer et ensuite créer un objet correspondant
            //Account account;
            Account TryRestorer = new Restorer();
            Account TryCustomer = new Customer();
            bool IsRestorer = false;
            bool IsCustomer = false;
            TryRestorer.Email = vm.user.Email;
            TryRestorer.Password =vm.user.Password;

            TryCustomer.Email = vm.user.Email;
            TryCustomer.Password = vm.user.Password;
            IsRestorer =TryRestorer.VerifyExistingRestorer(_accountDAL,TryRestorer);
            if (IsRestorer == true)
            {
                //traitement pour verifier
            }
            else
            {
                //IsCustomer=TryCustomer.
                if (IsCustomer == true)
                {
                    //traitement
                }
            }
            

            //if (ModelState.IsValid)
            //{
            //    Account RecuperatedAccount = account.Login(_accountDAL,account);

            //    if (account is Customer && account != null) {
            //        TempData["Message"] = "State0";

            //        if (String.IsNullOrEmpty(HttpContext.Session.GetString("customerConnected"))) {
            //            HttpContext.Session.SetInt32("CustomerId", RecuperatedAccount.Id);
            //            HttpContext.Session.SetString("Firstname", RecuperatedAccount.Firstname);
            //            HttpContext.Session.SetString("Lastname", RecuperatedAccount.Lastname);
            //            HttpContext.Session.SetString("Email", RecuperatedAccount.Email);
            //            HttpContext.Session.SetString("City", RecuperatedAccount.City);
            //            HttpContext.Session.SetString("PostalCode", RecuperatedAccount.Pc);
            //            HttpContext.Session.SetString("PhoneNumber", RecuperatedAccount.Tel);
            //            HttpContext.Session.SetString("Country", RecuperatedAccount.Country);
            //        }
            //        return View();
            //    } else if (account is Restorer && account != null) {
            //        TempData["Message"] = "State0";

            //        if (String.IsNullOrEmpty(HttpContext.Session.GetString("restorerConnected"))) {
            //            HttpContext.Session.SetInt32("CustomerId", RecuperatedAccount.Id);
            //            HttpContext.Session.SetString("Firstname", RecuperatedAccount.Firstname);
            //            HttpContext.Session.SetString("Lastname", RecuperatedAccount.Lastname);
            //            HttpContext.Session.SetString("Email", RecuperatedAccount.Email);
            //            HttpContext.Session.SetString("City", RecuperatedAccount.City);
            //            HttpContext.Session.SetString("PostalCode", RecuperatedAccount.Pc);
            //            HttpContext.Session.SetString("PhoneNumber", RecuperatedAccount.Tel);
            //            HttpContext.Session.SetString("Country", RecuperatedAccount.Country);
            //        }
            //        return View();
            //    }
            //}
            return View();
        }
    }
}
