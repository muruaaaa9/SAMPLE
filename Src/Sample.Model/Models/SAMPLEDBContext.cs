using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Sample.Model.Models.Mapping;

namespace Sample.Model.Models
{
    public class SAMPLEDBContext : DbContext, IDbContext
    {
        static SAMPLEDBContext()
        {
            Database.SetInitializer<SAMPLEDBContext>(null);
        }

		public SAMPLEDBContext()
			: base("Name=SAMPLEDBContext")
		{
		    this.Configuration.LazyLoadingEnabled = false;
		    this.Configuration.ProxyCreationEnabled = false;
		}

        public IDbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}
