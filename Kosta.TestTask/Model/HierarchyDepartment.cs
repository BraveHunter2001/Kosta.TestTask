using Kosta.TestTask.Domain.Entities;

namespace Kosta.TestTask.Model
{
    public class HierarchyDepartment
    {
        public Dictionary<Department, List<Department>> Hierarchy { get;set;}
        public Department Root { get; set; }
    }
}
