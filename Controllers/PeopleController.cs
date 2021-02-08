using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demomvc.Models;

namespace demomvc.Controllers
{
    public class PeopleController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListPeople()
        {
            var people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Ken", LastName = "Colón", Age = 20});
            people.Add(new PersonModel { FirstName = "Kat", LastName = "Otero", Age = 28});
            people.Add(new PersonModel { FirstName = "Noni", LastName = "Pagán", Age = 2});

            return View(people);
        }
    }
    
}