using DevFramework.Core.DataAccess;
using DevFramework.Northwnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwnd.DataAccess.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {

    }
}
