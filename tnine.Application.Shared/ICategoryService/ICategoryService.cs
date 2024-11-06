using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tnine.Application.Shared.ICategoryService.Dto;
using tnine.Application.Shared.ITodoService.Dto;
using tnine.Core.Shared.Dto;

namespace tnine.Application.Shared.ICategoryService
{
    public interface ICategoryService
    {
        Task<List<GetCategoryForViewDto>> GetAll();
        Task CreateOrEdit(CreateOrEditCategoryDto input);
        Task<GetCategoryForEditOutputDto> GetById(EntityDto<long> input);
        Task Delete(EntityDto<long> input);
    }
}
