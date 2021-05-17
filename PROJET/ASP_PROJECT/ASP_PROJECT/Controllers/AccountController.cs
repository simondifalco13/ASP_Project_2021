using ASP_PROJECT.DAL.IDAL;
using ASP_PROJECT.Models.Other;
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
        public IActionResult CustomerInscription()
        {
            return View();
        }

        public IActionResult Login()
        {
            LoginViewModel vm = new LoginViewModel();
            return View("Login", vm);
        }

        public IActionResult ConsultRestorerInformations()
        {
            Restorer restorer = new Restorer();
            restorer.Firstname = HttpContext.Session.GetString("Firstname");
            restorer.Lastname = HttpContext.Session.GetString("Lastname");
            restorer.Id = (int)HttpContext.Session.GetInt32("CustomerId");
            restorer.Email = HttpContext.Session.GetString("Email");
            restorer.City = HttpContext.Session.GetString("City");
            restorer.Address = HttpContext.Session.GetString("Address");
            restorer.Pc = HttpContext.Session.GetString("PostalCode");
            restorer.Tel = HttpContext.Session.GetString("PhoneNumber");
            restorer.Country = HttpContext.Session.GetString("Country");
            string gender= HttpContext.Session.GetString("Gender");
            restorer.Gender = gender[0];
            return View("ConsultRestorerInformations", restorer);
        }
        //POST
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
            return View("Index");
        }

        
        [HttpPost]
        public IActionResult Login(LoginViewModel vm)
        {
            //verifier si le mail est un custommer ou restorer et ensuite créer un objet correspondant
            //Account account;
            Account RecuperatedAccount;
            Account TryRestorer = new Restorer();
            Account TryCustomer = new Customer();
            bool IsRestorer = false;
            bool IsCustomer = false;
            TryRestorer.Email = vm.user.Email;
            TryRestorer.Password =vm.user.Password;

            TryCustomer.Email = vm.user.Email;
            TryCustomer.Password = vm.user.Password;

            if (vm.user.Email!=null && vm.user.Password!=null)
            {
                IsRestorer = TryRestorer.VerifyExistingRestorer(_accountDAL, TryRestorer);
                if (IsRestorer == true)
                {
                    try
                    {
                        RecuperatedAccount = Account.Login(_accountDAL, TryRestorer);
                        if (String.IsNullOrEmpty(HttpContext.Session.GetString("restorerConnected")))
                        {
                            TempData["Message"] = "State10";
                            HttpContext.Session.SetString("restorerConnected", "true");
                            HttpContext.Session.SetInt32("CustomerId", RecuperatedAccount.Id);
                            HttpContext.Session.SetString("Firstname", RecuperatedAccount.Firstname);
                            HttpContext.Session.SetString("Lastname", RecuperatedAccount.Lastname);
                            HttpContext.Session.SetString("Email", RecuperatedAccount.Email);
                            HttpContext.Session.SetString("City", RecuperatedAccount.City);
                            HttpContext.Session.SetString("Address", RecuperatedAccount.Address);
                            HttpContext.Session.SetString("PostalCode", RecuperatedAccount.Pc);
                            HttpContext.Session.SetString("PhoneNumber", RecuperatedAccount.Tel);
                            HttpContext.Session.SetString("Country", RecuperatedAccount.Country);
                            HttpContext.Session.SetString("Gender", RecuperatedAccount.Gender.ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        TempData["Exception"] = e.Message;

                    }
                }
                else
                {

                    IsCustomer = TryCustomer.VerifyExistingCustomer(_accountDAL, TryCustomer);
                    if (IsCustomer == true)
                    {
                        try
                        {
                            RecuperatedAccount = Account.Login(_accountDAL, TryCustomer);
                            if (String.IsNullOrEmpty(HttpContext.Session.GetString("customerConnected")))
                            {
                                TempData["Message"] = "State10";
                                HttpContext.Session.SetString("customerConnected", "true");
                                HttpContext.Session.SetInt32("CustomerId", RecuperatedAccount.Id);
                                HttpContext.Session.SetString("Firstname", RecuperatedAccount.Firstname);
                                HttpContext.Session.SetString("Lastname", RecuperatedAccount.Lastname);
                                HttpContext.Session.SetString("Email", RecuperatedAccount.Email);
                                HttpContext.Session.SetString("City", RecuperatedAccount.City);
                                HttpContext.Session.SetString("PostalCode", RecuperatedAccount.Pc);
                                HttpContext.Session.SetString("PhoneNumber", RecuperatedAccount.Tel);
                                HttpContext.Session.SetString("Country", RecuperatedAccount.Country);
                                HttpContext.Session.SetString("Gender", RecuperatedAccount.Gender.ToString());

                            }
                        }
                        catch(Exception e)
                        {
                            TempData["Exception"] = e.Message;
                        }
                    }
                    else
                    {
                        TempData["Message"] = "State1";
                    }
                }
            }
            else
            {
                TempData["Message"] = "Uncompleted";
            }
            return View("Index");
        }
    }
}
