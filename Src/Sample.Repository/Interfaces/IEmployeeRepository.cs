using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.Model.Models;

namespace Sample.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
    }
}
