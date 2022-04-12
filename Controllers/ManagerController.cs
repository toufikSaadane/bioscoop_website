using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace website.Controllers
{
    public class ManagerController : Controller
    {
        [Authorize(Roles = "Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}