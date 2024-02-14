using KodlamaioModelleme.Business.Abstracts;
using KodlamaioModelleme.Business.Dtos.Request.Category;
using KodlamaioModelleme.Business.Dtos.Responses.Category;
using KodlamaioModelleme.DataAccess.Abstracts;
using KodlamaioModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModelleme.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(CreateCategoryRequest category)
        {
            Category categoryToCreate = new Category();
            categoryToCreate.Name = category.Name;

            _categoryDal.Add(categoryToCreate);
        }

        public void Delete(DeleteCategoryRequest category)
        {
            Category categoryToDelete = new Category();
            categoryToDelete.Id = category.Id;
            _categoryDal.Delete(categoryToDelete);
        }


        public List<GetByIdCategoryResponse> GetById(int id)
        {
            List<GetByIdCategoryResponse> categories = new List<GetByIdCategoryResponse>();
            _categoryDal.GetById(id);
            return categories;
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();

            foreach (var category in _categoryDal.GetAll())
            {
                GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
                getAllCategoryResponse.Id = category.Id;
                getAllCategoryResponse.Name = category.Name;

                categories.Add(getAllCategoryResponse);
            }
            return categories;
        }

        public void Update(UpdateCategoryRequest category)
        {
            Category categoryToUpdate = new Category();
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.Name = category.Name;
            _categoryDal.Update(categoryToUpdate);
        }
    }
}
