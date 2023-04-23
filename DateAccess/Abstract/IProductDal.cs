using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        List<Product> GetAllByCatagory(int catagoryId);

    }
}
