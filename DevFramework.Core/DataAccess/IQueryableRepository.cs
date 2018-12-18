using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess
{
   public interface IQueryableRepository<T> where T:class, IEntity, new()
    {
        //ToList() görüldüğü anda vt ile ilgili context sonlanmış oluyor. Iqueryable operasyonların Business tarafında çalıştırılabilmesi için context kapanmadan bu Iquaeryable Interface i yazıldı.
        IQueryable<T> Table { get;} //readonly olacak
    }
}
