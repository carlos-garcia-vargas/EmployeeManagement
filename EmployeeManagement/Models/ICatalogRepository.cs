using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface ICatalogRepository
    {
        Catalog GetCatalog(int Id);
        IEnumerable<Catalog> GetAllCatalogs();
        Catalog Add(Catalog newCatalog);
        Catalog Update(Catalog catalogChanges);
        Catalog Delete(int id);
    }
}
