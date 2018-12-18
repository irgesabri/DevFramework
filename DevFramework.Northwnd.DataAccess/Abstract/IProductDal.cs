using DevFramework.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwnd.Entities.Concrete;
using DevFramework.Northwnd.Entities.ComplexTypes;

namespace DevFramework.Northwnd.DataAccess.Abstract
{
   public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
