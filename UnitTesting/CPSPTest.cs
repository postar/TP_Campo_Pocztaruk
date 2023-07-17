using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class CPSPTest
    {
        [TestMethod]
        public void CreateCPSP()
        {
            BLL.BLLCPSP bllcpsp = new BLL.BLLCPSP();
            bllcpsp.cpsp.codeP1 = new BE.COMPOSITEPRIVILEGE("ADM");
            bllcpsp.cpsp.codeP2 = new BE.SIMPLEPRIVILEGE("BTNDBA");
            int existing = bllcpsp.List().Count();
            bllcpsp.Add();
            int pexisting = bllcpsp.List().Count();
            Assert.AreEqual(existing+1, pexisting);
            bllcpsp.Remove();
        }

        [TestMethod]
        public void DeleteCPSP()
        {
            BLL.BLLCPSP bllcpsp = new BLL.BLLCPSP();
            bllcpsp.cpsp.codeP1 = new BE.COMPOSITEPRIVILEGE("ADM");
            bllcpsp.cpsp.codeP2 = new BE.SIMPLEPRIVILEGE("BTNDBA");
            bllcpsp.Add();
            int existing = bllcpsp.List().Count();
            bllcpsp.Remove();
            int pexisting = bllcpsp.List().Count();
            Assert.AreEqual(existing - 1, pexisting);
        }

    }
}
