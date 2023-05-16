using Core.DataAccess;
using DateAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace DateAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
