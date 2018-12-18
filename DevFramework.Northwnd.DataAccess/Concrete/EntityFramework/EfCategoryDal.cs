using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwnd.DataAccess.Abstract;
using DevFramework.Northwnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwnd.DataAccess.Concrete.EntityFramework
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwndContext>,ICategoryDal
    {

    }
}
