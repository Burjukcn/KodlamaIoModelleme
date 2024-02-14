using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModelleme.Business.Dtos.Request.Instruction
{
    public class UpdateInstructionRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InstructorId { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
    }
}
