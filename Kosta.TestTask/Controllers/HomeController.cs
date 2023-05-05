using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;
using Kosta.TestTask.Model;
using Kosta.TestTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kosta.TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly TreeCreator treeCreator;
        private HierarchyDepartment hierarchyDepartment;
        private ICollection<Employee> employeesByDepartment;
        public HomeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository, TreeCreator treeCreator)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            this.treeCreator = treeCreator;
        }
        public IActionResult Index()
        {
            DepartmentPageViewModel viewModel = new DepartmentPageViewModel();
            viewModel.HierarchyDepartment = treeCreator.GetDeportamentDict();

            return View(viewModel);
        }



        [HttpGet]
        public IActionResult EmployeesByDepartment(string id) {


            var idGuid = Guid.Parse(id);
            var department = _departmentRepository.GetDepartmentItemById(idGuid);
            employeesByDepartment = department.Employees;

            DepartmentPageViewModel viewModel = new DepartmentPageViewModel();
            viewModel.HierarchyDepartment = treeCreator.GetDeportamentDict();
            viewModel.EmployeesDepartamentId = department.Employees;
            return View("Index", viewModel);
        }
    }
}
