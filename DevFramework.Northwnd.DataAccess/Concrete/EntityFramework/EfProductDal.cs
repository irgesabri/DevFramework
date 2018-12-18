using DevFramework.Northwnd.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwnd.Entities.Concrete;
using System.Linq.Expressions;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwnd.Entities.ComplexTypes;

namespace DevFramework.Northwnd.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwndContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwndContext context = new NorthwndContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
            
        }
    }
}
