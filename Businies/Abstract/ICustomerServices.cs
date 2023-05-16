using Core.Utilities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerServices
    {
        IDataResult<List<Customer>> GetAll();
    }
}
