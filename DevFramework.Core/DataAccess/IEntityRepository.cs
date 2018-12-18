using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess
{
   public interface IEntityRepository<T> where T :class,IEntity,new()
       //butun vt nesneleri için generic çalışacak bir yapı oluşturmak istiyorum <T> yazıyorum. new() bu ibare newlenebilir olarak işaretliyorum
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        //istersem datanın tumunu, istersem datanın where koşulu ile belirtilen kısmını getirmek istiyorum. link expression eklediyorum. Func<T, bool> metod delegesi gönderecem.filter = null filter boş gelirse tum data gelecek. filter dolu gelirse filtrelenmiş data gelecek.
        T Get(Expression<Func<T, bool>> filter );
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        //gelen primary key int yada nvarchar olabilir.

    }
}
