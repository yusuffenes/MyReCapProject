using Core.Utilities.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }

}
