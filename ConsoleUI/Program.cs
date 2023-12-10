using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

namespace ConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {

        ProductManager productManager = new ProductManager(new EfProductDal());


        foreach (var product in productManager.GetByUnitPrice(100 , 500))
        {

            Console.WriteLine(product.ProductName);
        }




    }
}