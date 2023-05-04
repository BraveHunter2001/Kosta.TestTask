using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;

namespace Kosta.TestTask.Domain.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void DeleteDepartmentItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Department> GetDepartmentItems()
        {
            return _appDbContext.Departments;
        }

        public void SaveDepartmentItem(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
