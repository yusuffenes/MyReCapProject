using Business.Concrete;
using DateAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProudctTest();
            Console.WriteLine("İşlem Tamamlandı ! ");
        }

        private static void CustomerTest()
        {
            CustomerManager product = new CustomerManager(new EfCustomersDal());
            foreach (var item in product.GetAll().Data)
            {
                Console.WriteLine("Product Name  : " + item.ContactName + " City : " + item.City);
            }
        }

        private static void ProudctTest()
        {
            ProductManager product = new ProductManager(new EfProductDal());
            foreach (var item in product.GetProductDetails().Data)
            {
                Console.WriteLine( item.ProductName+ " / " + item.CategoryName);
            }
        }
    }
}
