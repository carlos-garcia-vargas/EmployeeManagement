using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
    public class CreateCatalogViewModel
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string CatalogName { get; set; }
        [Display(Name = "Value")]
        public string CatalogValue { get; set; }
        [Display(Name = "Parent")]
        public int? CatalogParentId { get; set; }
        public SelectList CatalogsList { get; set; } 

        public IList<ValueRow> ValueRows { get; set; }
    }

    public class ValueRow
    {
        public int? Id { get; set; }
        public string CatalogValue { get; set; }
    }
}
