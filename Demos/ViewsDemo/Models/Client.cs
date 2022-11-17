using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewsDemo.Models
{
    public class Client
    {
        public string Societe { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Email { get; set; }
    }
}