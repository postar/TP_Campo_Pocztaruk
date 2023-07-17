using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTesting
{
    [TestClass]
    public class PrivilegeTest
    {
        [TestMethod]
        public void AddPrivilege()
        {
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.SIMPLEPRIVILEGE simple = new BE.SIMPLEPRIVILEGE("BTNTEST");
            int existing = bLLPrivilege.List().Count;
            bLLPrivilege.Add(simple);
            int pexisting = bLLPrivilege.List().Count;
            Assert.AreEqual(existing + 1, pexisting);
            bLLPrivilege.Remove(simple);
        }

        [TestMethod]
        public void DeletePrivilege()
        {
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.SIMPLEPRIVILEGE simple = new BE.SIMPLEPRIVILEGE("BTNTEST");
            bLLPrivilege.Add(simple);
            int existing = bLLPrivilege.List().Count;
            bLLPrivilege.Remove(simple);
            int pexisting = bLLPrivilege.List().Count;
            Assert.AreEqual(existing - 1, pexisting);
            
        }

        [TestMethod]
        public void GetByID()
        {
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.SIMPLEPRIVILEGE simple = new BE.SIMPLEPRIVILEGE("BTNTEST");
            bLLPrivilege.Add(simple);
            BE.PRIVILEGE existing = bLLPrivilege.GetPrivilege("BTNTEST");
            Assert.IsNotNull(existing);
            bLLPrivilege.Remove(simple);
        }

        [TestMethod]
        public void GetByType()
        {
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            List<BE.PRIVILEGE> existing = bLLPrivilege.List();
            Assert.AreNotEqual(0, existing.Count);
        }

        [TestMethod]
        public void Group()
        {
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.SIMPLEPRIVILEGE simple = new BE.SIMPLEPRIVILEGE("BTNTEST");
            bLLPrivilege.Add(simple);
            BE.COMPOSITEPRIVILEGE composite = new BE.COMPOSITEPRIVILEGE("TESTCOMPOSITE");
            bLLPrivilege.Add(composite);
            BE.PRIVILEGE existing = bLLPrivilege.GetPrivilege("BTNTEST");
            bLLPrivilege.Group(composite, simple);
            Assert.IsNotNull(existing);
            bLLPrivilege.UnGroup(composite, simple);
            bLLPrivilege.Remove(composite);
            bLLPrivilege.Remove(simple);
        }
    }
}
