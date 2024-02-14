using KodlamaioModelleme.Business.Dtos.Request.Instruction;
using KodlamaioModelleme.Business.Dtos.Responses.Instruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModelleme.Business.Abstracts
{
    public interface IInstructionService
    {
        void Add(CreateInstructionRequest instruction);
        void Delete(DeleteInstructionRequest instruction);
        void Update(UpdateInstructionRequest instruction);
        List<GetAllInstructionResponse> GetAll();
        List<GetByIdInstructionResponse> GetById(int id);

    }
}
