using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;
using Kosta.TestTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kosta.TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly TreeCreator treeCreator;
        public HomeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {

            TreeCreator treeCreator = new TreeCreator(_departmentRepository);
            var treeDepart = treeCreator.GetDeportamentDict();
            ViewData["TreeRoot"] = treeCreator.Root;
            ViewData["Tree"] = treeDepart;
            return View();
        }

       
    }
}
