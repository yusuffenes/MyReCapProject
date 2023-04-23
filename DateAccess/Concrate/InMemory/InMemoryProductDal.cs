using DateAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Concrate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,CatagoryId = 1,ProductName = "Bardak",UnitPrice = 15,UnitStock = 15},
                new Product{ProductId = 2,CatagoryId = 1,ProductName = "Kamera",UnitPrice = 500,UnitStock = 3},
                new Product{ProductId = 3,CatagoryId = 2,ProductName = "Telefon",UnitPrice = 1500,UnitStock = 2},
                new Product{ProductId = 4,CatagoryId = 2,ProductName = "Klavye",UnitPrice = 150, UnitStock = 65},
                new Product{ProductId = 5,CatagoryId = 2,ProductName = "Fare",UnitPrice = 85,UnitStock= 1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null ;
            foreach (var item in _products)
            {
                if (item.ProductId == product.ProductId)
                {
                    productToDelete = item;
                }
            }
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCatagory(int catagoryId)
        {
            return _products.Where(p => p.CatagoryId == catagoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            product.ProductId = productToUpdate.ProductId;
            product.ProductName = productToUpdate.ProductName;
            product.UnitPrice = productToUpdate.UnitPrice;
            product.UnitStock = productToUpdate.UnitStock;
            product.CatagoryId= productToUpdate.CatagoryId;
        }
    }
}
