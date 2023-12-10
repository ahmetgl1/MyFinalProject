using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{

    private readonly ICategoryDal categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        this.categoryDal = categoryDal;
    }

    public List<Category> Get()
    {





        return categoryDal.GetAll();

    }

    public List<Category> GetCategoryById(int id)
    {
      

        return categoryDal.GetAll(o => o.CategoryId == id); 

    }
}
