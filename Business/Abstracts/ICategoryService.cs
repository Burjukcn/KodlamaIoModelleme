using KodlamaioModelleme.Business.Dtos.Request.Category;
using KodlamaioModelleme.Business.Dtos.Responses.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModelleme.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest category);
        void Delete(DeleteCategoryRequest category);
        void Update(UpdateCategoryRequest category);
        List<GetAllCategoryResponse> GetAll();
        List<GetByIdCategoryResponse> GetById(int id);
    }
}
