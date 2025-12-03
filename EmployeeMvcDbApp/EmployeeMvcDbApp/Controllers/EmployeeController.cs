using EmployeeMvcDbApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMvcDbApp.Controllers
{
    public class EmployeeController : Controller
    {

        private EmployeeDbContext _db;

        public EmployeeController(EmployeeDbContext dbContext) { 
        
            _db = dbContext;
        
        }
        public IActionResult Index()
        {
            ViewBag.EmpCount = _db.Employees.Count();
             
            return View(_db.Employees.ToList());//Strongly typed view
        }
    }
}
