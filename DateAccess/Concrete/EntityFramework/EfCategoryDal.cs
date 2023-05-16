using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
