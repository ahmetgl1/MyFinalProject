using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
{


public List<ProductDetailDto> GetProductDetail()
{
    using (var context = new NorthwindContext())
    {
        var productDetails = (from product in context.Products
                              join category in context.Categories
                              on product.CategoryId equals category.CategoryId
                              select new ProductDetailDto
                              {
                                  ProductId = product.ProductId,
                                  ProductName = product.ProductName,
                                  CategoryName = category.CategoryName,
                                  UnitsInStock = product.UnitsInStock
                              }).ToList();

        return productDetails;
    }
}


}
