using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public class SQLCatalogRepository : ICatalogRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SQLCatalogRepository> logger;

        public SQLCatalogRepository(AppDbContext context, ILogger<SQLCatalogRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public Catalog Add(Catalog newCatalog)
        {
            try
            {
                context.Catalogs.Add(newCatalog);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                logger.LogError("Error Log: " + ex.Message);
            }
            return newCatalog;
        }

        public Catalog Delete(int id)
        {
            Catalog catalog = context.Catalogs.Find(id);
            if (catalog != null)
            {
                context.Catalogs.Remove(catalog);
                context.SaveChanges();
            }
            return catalog;
        }

        public IEnumerable<Catalog> GetAllCatalogs()
        {
            return context.Catalogs;
        }

        public Catalog GetCatalog(int Id)
        {
            var catalog = context.Catalogs.Find(Id);
            if (catalog != null) { 
                context.Entry(catalog)
                .Collection(b => b.CatalogDetails)
                .Load();            
            }

            return catalog;
        }

        public Catalog Update(Catalog catalogChanges)
        {            
            var catalog = context.Catalogs.Attach(catalogChanges);
            catalog.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return catalogChanges;
        }
    }
}
