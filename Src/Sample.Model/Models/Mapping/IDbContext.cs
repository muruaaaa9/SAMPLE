using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Sample.Model.Models.Mapping
{
    public interface IDbContext : IDisposable
    {
        IDbSet<Employee> Employees { get; set; }
    }
}
