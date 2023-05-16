using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCustomersDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        
    }
}
