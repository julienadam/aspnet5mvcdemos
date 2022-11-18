using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bogus;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class ClientController : Controller
    {
        private readonly Faker<Client> clientFaker = new Faker<Client>()
            .RuleFor(c => c.Nom, f => f.Person.LastName)
            .RuleFor(c => c.Prenom, f => f.Person.FirstName)
            .RuleFor(c => c.Societe, f => f.Company.CompanyName())
            .RuleFor(c => c.DateNaissance, f => f.Person.DateOfBirth)
            .RuleFor(c => c.Email, f => f.Person.Email);
        

        // GET: Client
        public ActionResult Index()
        {
            return View(clientFaker.Generate());
        }

        public ActionResult List()
        {
            return View(clientFaker.GenerateLazy(25));
        }
    }
}