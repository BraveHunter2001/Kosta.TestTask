using Kosta.TestTask.Domain.Entities;

namespace Kosta.TestTask.Model
{
    public class DepartmentPageViewModel
    {
        public HierarchyDepartment HierarchyDepartment { get; set; }
        public ICollection<Employee> EmployeesDepartamentId { get; set; }
    }
}
