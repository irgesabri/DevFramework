using DevFramework.Northwnd.DataAccess.Concrete.EntityFramework.Mapping;
using DevFramework.Northwnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwnd.DataAccess.Concrete.EntityFramework
{
    public class NorthwndContext : DbContext
    {
        public NorthwndContext()
        {
            Database.SetInitializer<NorthwndContext>(null);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
