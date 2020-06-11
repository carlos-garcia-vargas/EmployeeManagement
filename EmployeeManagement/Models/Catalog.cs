using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Value { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<CatalogDetail> CatalogDetails { get; set; }
    }
}
