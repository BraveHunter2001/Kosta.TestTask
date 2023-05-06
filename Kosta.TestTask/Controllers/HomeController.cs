using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;
using Kosta.TestTask.Model;
using Kosta.TestTask.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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



        [HttpPost]
        public IActionResult EmployeesByDepartment([FromBody]string id) {


            var idGuid = Guid.Parse(id);
            var department = _departmentRepository.GetDepartmentItemById(idGuid);
            List<EmployeeJsonModel> list = new List<EmployeeJsonModel>();

            foreach (var employee in department.Employees)
            {
                list.Add(new EmployeeJsonModel()
                {
                    ID = employee.ID,
                    SurName = employee.SurName,
                    FirstName = employee.FirstName,
                    Patronymic = employee.Patronymic,
                    Age = employee.Age,
                    DateOfBirth = employee.DateOfBirth,
                    DocNumber = employee.DocNumber,
                    DocSeries = employee.DocSeries,
                    Position = employee.Position,
                });
            }
          

            return new JsonResult(list);
        }
    }
}
