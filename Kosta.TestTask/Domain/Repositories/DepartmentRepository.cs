using Kosta.TestTask.Domain.Entities;
using Kosta.TestTask.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            return;
        }

        public Department GetDepartmentItemById(Guid id)
        {
            return _appDbContext.Departments.Include(d=>d.Employees).FirstOrDefault(d=>d.ID == id);
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
