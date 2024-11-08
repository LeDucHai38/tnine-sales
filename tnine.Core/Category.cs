using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tnine.Core.Auditing;

namespace tnine.Core
{
    [Table("Categories")]

    public class Category : FullAuditedEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}
