using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevFramework.Northwnd.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwnd.Entities;

namespace DevFramework.Northwnd.Business.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(79, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(x=>x.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);
        }
    }
}
