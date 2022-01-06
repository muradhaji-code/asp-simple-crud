using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06._01._2022_ASP_SimpleCRUD.Areas.admin.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController(AppContext context)
        {

        }
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
