using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tnine.Core.Shared.Dto;

namespace tnine.Application.Shared.ICategoryService.Dto
{
    internal class GetCategoryInputDto : EntityDto<long>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
    }
}
