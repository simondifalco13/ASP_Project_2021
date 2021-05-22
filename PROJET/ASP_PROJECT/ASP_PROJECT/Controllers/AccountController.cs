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

        public IActionResult Inscription()
        {
            return View("Inscription");
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
            restorer.Id = (int)HttpContext.Session.GetInt32("restorerId");
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

        public IActionResult ConsultCustomerInformations()
        {
            Customer customer = new Customer();
            customer.Firstname = HttpContext.Session.GetString("Firstname");
            customer.Lastname = HttpContext.Session.GetString("Lastname");
            customer.Id = (int)HttpContext.Session.GetInt32("CustomerId");
            customer.Email = HttpContext.Session.GetString("Email");
            customer.City = HttpContext.Session.GetString("City");
            customer.Address = HttpContext.Session.GetString("Address");
            customer.Pc = HttpContext.Session.GetString("PostalCode");
            customer.Tel = HttpContext.Session.GetString("PhoneNumber");
            customer.Country = HttpContext.Session.GetString("Country");
            string dobStr= HttpContext.Session.GetString("DoB");
            customer.DoB = DateTime.Parse(dobStr);
            string gender = HttpContext.Session.GetString("Gender");
            customer.Gender = gender[0];
            return View("ConsultCustomerInformations", customer);
        }

        public void UpdateRestorerSessionInformations(Restorer Account)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("restorerConnected")))
            {
                HttpContext.Session.SetString("restorerConnected", "true");
                HttpContext.Session.SetInt32("CustomerId", Account.Id);
                HttpContext.Session.SetString("Firstname", Account.Firstname);
                HttpContext.Session.SetString("Lastname", Account.Lastname);
                HttpContext.Session.SetString("Email", Account.Email);
                HttpContext.Session.SetString("City", Account.City);
                HttpContext.Session.SetString("Address", Account.Address);
                HttpContext.Session.SetString("PostalCode", Account.Pc);
                HttpContext.Session.SetString("PhoneNumber",Account.Tel);
                HttpContext.Session.SetString("Country",Account.Country);
                HttpContext.Session.SetString("Gender", Account.Gender.ToString());
            }
        }

        public void UpdateCustomerSessionInformations(Customer Account)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("customerConnected")))
            {
                HttpContext.Session.SetString("restorerConnected", "true");
                HttpContext.Session.SetInt32("CustomerId", Account.Id);
                HttpContext.Session.SetString("Firstname", Account.Firstname);
                HttpContext.Session.SetString("Lastname", Account.Lastname);
                HttpContext.Session.SetString("Email", Account.Email);
                HttpContext.Session.SetString("City", Account.City);
                HttpContext.Session.SetString("Address", Account.Address);
                HttpContext.Session.SetString("PostalCode", Account.Pc);
                HttpContext.Session.SetString("PhoneNumber", Account.Tel);
                HttpContext.Session.SetString("Country", Account.Country);
                HttpContext.Session.SetString("DoB", ((Customer)Account).DoB.ToString("d"));
                HttpContext.Session.SetString("Gender", Account.Gender.ToString());
            }
        }

        public IActionResult ModifyRestorerInformations(string RestorerEmail)
        {
            Restorer RestorerToModify = Restorer.GetRestorerByMail(_accountDAL, RestorerEmail);
            return View("ModifyRestorerAccount",RestorerToModify);
        }
        public IActionResult ModifyCustomerInformations(string CustomerEmail)
        {
            Customer RestorerToModify = Customer.GetCustomerByMail(_accountDAL, CustomerEmail);
            return View("ModifyCustomerAccount", RestorerToModify);
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
                            HttpContext.Session.SetInt32("restorerId", RecuperatedAccount.Id);
                            HttpContext.Session.SetString("Firstname", RecuperatedAccount.Firstname);
                            HttpContext.Session.SetString("Lastname", RecuperatedAccount.Lastname);
                            HttpContext.Session.SetString("Email", RecuperatedAccount.Email);
                            HttpContext.Session.SetString("City", RecuperatedAccount.City);
                            HttpContext.Session.SetString("Address", RecuperatedAccount.Address);
                            HttpContext.Session.SetString("PostalCode", RecuperatedAccount.Pc);
                            HttpContext.Session.SetString("PhoneNumber", RecuperatedAccount.Tel);
                            HttpContext.Session.SetString("Country", RecuperatedAccount.Country);
                            HttpContext.Session.SetString("Gender", RecuperatedAccount.Gender.ToString());
                            return RedirectToAction("ConsultRestorerRestaurants", "Restaurant",new { Id = RecuperatedAccount.Id });
                        }
                        else
                        {
                            //message d'erreur si déja connexté
                            return View("Login", vm);
                        }
                    }
                    catch (Exception e)
                    {
                        TempData["Exception"] = e.Message;
                        return View("Login", vm);

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
                                TempData["Message"] = "State11";
                                HttpContext.Session.SetString("customerConnected", "true");
                                HttpContext.Session.SetInt32("CustomerId", RecuperatedAccount.Id);
                                HttpContext.Session.SetString("Firstname", RecuperatedAccount.Firstname);
                                HttpContext.Session.SetString("Lastname", RecuperatedAccount.Lastname);
                                HttpContext.Session.SetString("Email", RecuperatedAccount.Email);
                                HttpContext.Session.SetString("Address", RecuperatedAccount.Address);
                                HttpContext.Session.SetString("City", RecuperatedAccount.City);
                                HttpContext.Session.SetString("PostalCode", RecuperatedAccount.Pc);
                                HttpContext.Session.SetString("PhoneNumber", RecuperatedAccount.Tel);
                                HttpContext.Session.SetString("Country", RecuperatedAccount.Country);
                                HttpContext.Session.SetString("DoB", ((Customer)RecuperatedAccount).DoB.ToString("d"));
                                HttpContext.Session.SetString("Gender", RecuperatedAccount.Gender.ToString());
                                HttpContext.Session.SetString("OrderExist", "true");
                                HttpContext.Session.SetString("DishesOrder", "");
                                HttpContext.Session.SetString("MenusOrder", "");
                                return RedirectToAction("ConsultRestaurant", "Restaurant");
                            }
                            else
                            {
                                //message d'erreur si déja connexté
                                return View("Login", vm);
                            }
                        }
                        catch(Exception e)
                        {
                            TempData["Exception"] = e.Message;
                            return View("Login", vm);
                        }
                    }
                    else
                    {
                        TempData["Message"] = "State1";
                        return View("Login", vm);
                    }
                }
            }
            else
            {
                TempData["Message"] = "Uncompleted";
                return View("Login", vm);
            }
        }

        [HttpPost]
        public IActionResult ModifyRestorerInformations(Restorer RestorerToModify)
        {
            string mail = HttpContext.Session.GetString("Email");
            Restorer RestOfInformations = Restorer.GetRestorerByMail(_accountDAL,mail);
            RestorerToModify.Id = RestOfInformations.Id;
            RestorerToModify.Email = RestOfInformations.Email;
            if (RestorerToModify.Firstname != null
                && RestorerToModify.Lastname != null
                && RestorerToModify.Gender != 0
                && RestorerToModify.Address != null
                && RestorerToModify.City != null
                && RestorerToModify.Address != null
                && RestorerToModify.Pc != null
                && RestorerToModify.Tel != null)
            {
                bool success = Restorer.ModifyRestorerInformations(_accountDAL, RestorerToModify);
                if (success == true)
                {
                    UpdateRestorerSessionInformations(RestorerToModify);
                    TempData["AccountModifications"] = "success";
                    return View("ConsultRestorerInformations",RestorerToModify);
                }
            }
            else
            {
                TempData["AccountModifications"] = "invalid";
            }
            return View("ModifyRestorerAccount", RestorerToModify);
        }

        [HttpPost]
        public IActionResult ModifyCustomerInformations(Customer CustomerToModify)
        {
            string mail = HttpContext.Session.GetString("Email");
            Customer RestOfInformations = Customer.GetCustomerByMail(_accountDAL, mail);
            CustomerToModify.Id = RestOfInformations.Id;
            CustomerToModify.Email = RestOfInformations.Email;
            if (CustomerToModify.Firstname != null
                && CustomerToModify.Lastname != null
                && CustomerToModify.Gender != 0
                && CustomerToModify.Address != null
                && CustomerToModify.City != null
                && CustomerToModify.Address != null
                && CustomerToModify.Pc != null
                && CustomerToModify.Tel != null)
            {
                bool success = Customer.ModifyCustomerInformations(_accountDAL, CustomerToModify);
                if (success == true)
                {
                    UpdateCustomerSessionInformations(CustomerToModify);
                    TempData["AccountModifications"] = "success";
                    return View("ConsultCustomerInformations", CustomerToModify);
                }
            }
            else
            {
                TempData["AccountModifications"] = "invalid";
            }
            return View("ModifyCustomerAccount", CustomerToModify);
        }

        [HttpPost]
        public IActionResult Inscription(string type)
        {
            if (type == "restorer")
            {
                return View("RestorerInscription");
            }
            else
            {
                return View("CustomerInscription");
            }
        }
    }
}
