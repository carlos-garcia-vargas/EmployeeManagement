using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class CatalogDetail
    {
        public int Id { get; set; }
        public int? CatalogId { get; set; }
        [Required]
        public string CatalogValue { get; set; }
        public virtual Catalog Catalog { get; set; }
    }
}
