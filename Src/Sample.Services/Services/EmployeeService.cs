using Sample.Model.Models;
using Sample.Repository;
using Sample.Services.DataContract;

namespace Sample.Services.Services
{
    public class EmployeeService : IEmployee
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository(new SAMPLEDBContext());
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }
    }
}
