using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            var client = new Client
            {
                Nom = "Morris",
                Prenom = "Jeanne",
                DateNaissance = new DateTime(1975, 11, 5),
                Societe = "ACME Inc.",
                Email = "jeanne@acme.inc"
            };
            return View(client);
        }
    }
}