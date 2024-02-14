using KodlamaioModelleme.Business.Dtos.Request.Instructor;
using KodlamaioModelleme.Business.Dtos.Responses.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModelleme.Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(CreateInstructorRequest instructor);
        void Delete(DeleteInstructorRequest instructor);
        void Update(UpdateInstructorRequest instructor);
        List<GetAllInstructorResponse> GetAll();
        List<GetByIdInstructorResponse> GetById(int id);
    }
}
