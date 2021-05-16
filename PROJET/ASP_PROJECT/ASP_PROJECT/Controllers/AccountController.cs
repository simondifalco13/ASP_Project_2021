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
        public IActionResult Index() {
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
            return View();
        }
        [HttpPost]
        public IActionResult Login(Account account)
        {
            if (ModelState.IsValid)
            {
                Account RecuperatedAccount = account.Login(_accountDAL,account);
                //parser en bon type de POCO (customer ou restorer) via des 'is' pour verifier 
                //recuperer objet : si l'objet est différent de null : renvoyer vue (peu importe) + message  (vue avec un lien vers les actions du type de compte) 
                //attention prévenir car on doit modifier les 'account' en dur dans  les actions faits auparavant 
                //l'objet va être stocké en session -> via cela on pourra récuperer 
                //quand logged est ok -> fonction pour récuperer les restaurant et les stocker dans l'objet qu'on envoit dans ces méthodes -> via le restorer Id 

                //if (success == true)
                //{
                //    TempData["Message"] = "State0";
                //    return View();
                //}
                //else
                //{
                //    TempData["Message"] = "State1";
                //}
            }
            return View();
        }
    }
}
