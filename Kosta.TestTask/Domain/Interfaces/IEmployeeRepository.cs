using Kosta.TestTask.Domain.Entities;

namespace Kosta.TestTask.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetEmployeeItems();
        Employee GetEmployeeItemById(Guid id);
        void SaveEmployeeItem(Employee entity);
        void DeleteEmployeeItem(Guid id);
    }
}
