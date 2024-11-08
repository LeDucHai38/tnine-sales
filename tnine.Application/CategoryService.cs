using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tnine.Application.Shared.ICategoryService;
using tnine.Application.Shared.ICategoryService.Dto;
using tnine.Application.Shared.ICategoryService;
using tnine.Application.Shared.ICategoryService.Dto;
using tnine.Core.Shared.Infrastructure;
using tnine.Core.Shared.Repositories;
using tnine.Core.Shared.Dto;

namespace tnine.Application
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository productRepo, IUnitOfWork unitOfWork)
        {
            _categoryRepo = productRepo;
            _unitOfWork = unitOfWork;
        }

        public Task CreateOrEdit(CreateOrEditCategoryDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(EntityDto<long> input)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<GetCategoryForViewDto>> GetAll()
        {
            var categories = await _categoryRepo.GetAllAsync();
            return categories.Select(p => new GetCategoryForViewDto
            {
                Id = (int)p.Id,
                Name = p.Name,
                Description = p.Description
            }).ToList();

        }

        public Task<GetCategoryForEditOutputDto> GetById(EntityDto<long> input)
        {
            throw new System.NotImplementedException();
        }
    }
}
