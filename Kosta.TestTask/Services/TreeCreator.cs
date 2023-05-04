using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Kosta.TestTask.Services
{

    public class TreeCreator
    {
        private readonly IDepartmentRepository _departmentRepository;
        private Dictionary<Department, List<Department>> departDic;
        public Department Root { get; private set; }
        public TreeCreator(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public Dictionary<Department, List<Department>> GetDeportamentDict()
        {
            departDic = new Dictionary<Department, List<Department>>();
            List<Department> departments = _departmentRepository
                .GetDepartmentItems()
                .Include(d => d.Employees)
            .ToList();

            foreach (var dep in departments)
            {
                if (dep.ParentDepartment == null)
                    Root = dep;
                departDic.Add(dep, null);

            }

            foreach (var dep in departments)
                DFSDict(dep);


            return departDic;
        }

        void DFSDict(Department department)
        {
            if (department.ParentDepartment == null)
                return;

            DFSDict(department.ParentDepartment);
            //Console.WriteLine(department.Code);
            if (departDic[department.ParentDepartment] == null || !departDic[department.ParentDepartment].Contains(department))
            {
                if (departDic[department.ParentDepartment] == null)
                    departDic[department.ParentDepartment] = new List<Department>();
                departDic[department.ParentDepartment].Add(department);
            }
        }

      

    }
}
