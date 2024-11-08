using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tnine.Core.Shared.Dto;

namespace tnine.Application.Shared.ICategoryService.Dto
{
    public class GetCategoryForViewDto : PagedAndSortedResultRequestDto
    {
        public string Description;
        public long Id;

        public string FilterText { get; set; }
        public string Name { get; set; }
    }
}
