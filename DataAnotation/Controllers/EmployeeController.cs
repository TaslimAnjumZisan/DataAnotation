using DataAnotation.Context;
using System.Linq;
using System.Web.Mvc;

namespace DataAnotation.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
       

    }
}