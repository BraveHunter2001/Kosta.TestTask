using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;

namespace Kosta.TestTask.Domain.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext context)
        {
            this._appDbContext = context;
        }
        public void DeleteEmployeeItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> GetEmployeeItems()
        {
            return _appDbContext.Employees;
        }

        public void SaveEmployeeItem(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
