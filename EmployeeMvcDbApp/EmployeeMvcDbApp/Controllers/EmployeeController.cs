using Microsoft.AspNetCore.Mvc;

namespace EmployeeMvcDbApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
