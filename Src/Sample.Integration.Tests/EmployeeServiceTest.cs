using NUnit.Framework;
using Sample.Infrastructure;
using Sample.Model.Models;
using Sample.Services.DataContract;

namespace Sample.Integration.Tests
{
    [TestFixture]
    public class EmployeeServiceTest
    {
        private IEmployee _dataService;

        [SetUp]
        public void SetUp()
        {
            _dataService = AutoFacContainer.Resolve<IEmployee>();
        }
        [Test]
        public void ShouldGetEmployeeById()
        {
            Employee emp = _dataService.GetEmployeeById(1);
            Assert.That(emp.Name, Is.EqualTo("Test"));
        }
    }
}
