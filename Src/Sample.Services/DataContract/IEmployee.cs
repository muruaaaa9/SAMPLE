using System.ServiceModel;
using Sample.Model.Models;

namespace Sample.Services.DataContract
{
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        Employee GetEmployeeById(int id);
    }
}
