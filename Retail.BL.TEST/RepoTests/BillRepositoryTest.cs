using Microsoft.VisualStudio.TestTools.UnitTesting;
using Retail.BL.Repository;
using System;
using System.Collections.Generic;

namespace Retail.BL.TEST.RepoTests
{
    [TestClass]
    public class BillRepositoryTest
    {
        [TestMethod]
        public void Delete_AnItemThatExcist_ReturnTrue()
        {
            BillRepository repo = new BillRepository();

            bool result = repo.Delete(1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete_AnItemThatDoesNotExcist_ReturnFalse()
        {
            BillRepository repo = new BillRepository();

            bool result = repo.Delete(2);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Retrieve_AnItemThatDoesNotExcist_ReturnNull()
        {
            BillRepository repo = new BillRepository();

            Bill result = repo.Retrieve(2);

            Assert.IsNull(result);
        }
        [TestMethod]
        public void Retrieve_AnItemThatExcist_ReturnAnIntance()
        {
            BillRepository repo = new BillRepository();

            Bill result = repo.Retrieve(1);

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Update_AnItemThatExcist_ReturnsTheSameInstance()
        {
            BillRepository repo = new BillRepository();

            Bill expected = new Bill(1);

            Bill result = repo.Update(new Bill(1));

            Assert.AreEqual(expected.BillId, result.BillId);
        }
        [TestMethod]
        public void Update_AnItemThatDoesNotExcist_ReturnsNull()
        {
            BillRepository repo = new BillRepository();

            Bill result = repo.Update(new Bill(2));

            Assert.IsNull(result);
        }
    }
}
