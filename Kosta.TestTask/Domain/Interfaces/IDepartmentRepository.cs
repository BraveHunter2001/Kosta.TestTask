using Kosta.TestTask.Domain.Entities;

namespace Kosta.TestTask.Domain.Interfaces
{
    public interface IDepartmentRepository
    {
        IQueryable<Department> GetDepartmentItems();
        Department GetDepartmentItemById(Guid id);
        void SaveDepartmentItem(Department entity);
        void DeleteDepartmentItem(Guid id);
    }
}
