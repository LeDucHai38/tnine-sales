using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tnine.Application.Shared.ITodoService.Dto;

namespace tnine.Application.Shared.ICategoryService.Dto
{
    public class GetCategoryForEditOutputDto
    {
        public CreateOrEditTodoDto Category { get; set; }
    }
}
