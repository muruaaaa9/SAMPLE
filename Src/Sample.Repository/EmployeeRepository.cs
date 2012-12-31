using Sample.Model.Models;
using Sample.Model.Models.Mapping;
using Sample.Repository.Interfaces;
using System.Linq;

namespace Sample.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbContext _dbContext;

        public EmployeeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbContext.Employees.SingleOrDefault(s => s.Id == id);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
