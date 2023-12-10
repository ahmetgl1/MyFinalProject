using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class ProductManager : IProductService
{

    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        

        return _productDal.GetAll();

    }

    public List<Product> GetAllCategoryById(int id)
    {


        return _productDal.GetAll(o => o.CategoryId == id).ToList();
    }

    public List<Product> GetByUnitPrice(decimal min, decimal max)
    {


        return _productDal.GetAll(o => o.UnitPrice < max && o.UnitPrice > min).ToList();


    }

    public List<ProductDetailDto> GetProductDetailDtos()
    {
        
        return _productDal.GetProductDetail();
    }
}
