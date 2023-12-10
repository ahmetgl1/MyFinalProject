using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory;

public class InMemoryProductDal : IProductDal
{


    List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product> {

        new Product{ProductId =1 , ProductName= "Laptop" , UnitPrice = 14500 , CategoryId=1 , UnitsInStock=16},
        new Product{ProductId =2 , ProductName= "Klavye" , UnitPrice = 350 , CategoryId=2 , UnitsInStock=147},
        new Product{ProductId =3 , ProductName= "Kasa" , UnitPrice = 3650 , CategoryId=3 , UnitsInStock=25},
        new Product{ProductId =4 , ProductName= "Harddisk" , UnitPrice = 260 , CategoryId=4 , UnitsInStock=21},
        new Product{ProductId =5 , ProductName= "SSD" , UnitPrice = 1200 , CategoryId=4 , UnitsInStock=64}

        };



    }

    public void Add(Product product)
    {

        _products.Add(product);
    }

    public void Delete(Product product)
    {

        var deletedProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
        if(deletedProduct is null)
        {
            Console.WriteLine("Bulunamadı !");
        }
        _products.Remove(deletedProduct);




    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return (_products);
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllByCategoryId(int categoryId)
    {

      return   _products.Where(o => o.CategoryId == categoryId).ToList();



    }

    public List<ProductDetailDto> GetProductDetail()
    {
        throw new NotImplementedException();
    }

    public void Update(Product product)
    {


        var updatedProduct = _products.FirstOrDefault(o => o.ProductId == product.ProductId);

            if(updatedProduct is not null)
        {
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.UnitsInStock = product.UnitsInStock;
        }




    }
}
