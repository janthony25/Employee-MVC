using Employee.Data;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;   
        }

        public IActionResult Index()
        {
            IEnumerable<EmployeeList> obj = _db.employees;
            return View(obj);
        }
    }
}
