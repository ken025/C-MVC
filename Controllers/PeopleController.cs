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
    }
    
}