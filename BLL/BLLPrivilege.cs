using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLLPrivilege
    {
        DAL.MP_PRIVILEGE dalpriv;
        public BLLPrivilege()
        {
            dalpriv = new DAL.MP_PRIVILEGE();
        }
        public List<BE.PRIVILEGE> List()
        {
            List<BE.PRIVILEGE> Aux = dalpriv.List();
            BLLCPSP bLLCPSP = new BLLCPSP();
            foreach (BE.CPSP P in bLLCPSP.List())
            {
                BE.PRIVILEGE aux = Aux.Find(x => x.code == P.codeP2.code);
                (Aux.Find(x => x.code == P.codeP1.code) as BE.COMPOSITEPRIVILEGE).PrivilegeList.Add(aux);
            }
            return Aux;
        }
        public void Add(BE.PRIVILEGE priv)
        {
            dalpriv.Insert(priv);
        }
        public void Remove(BE.PRIVILEGE priv)
        {
            dalpriv.Delete(priv);
        }
        public BE.PRIVILEGE GetPrivilege(string code)
        {
            return dalpriv.GetByID(code);
        }
        public void Group(BE.COMPOSITEPRIVILEGE cp, BE.SIMPLEPRIVILEGE sp)
        {
            BLLCPSP bLLCPSP = new BLLCPSP();
            bLLCPSP.cpsp.codeP1 = cp;
            bLLCPSP.cpsp.codeP2 = sp;
            bLLCPSP.Add();
        }
        public void UnGroup(BE.COMPOSITEPRIVILEGE cp, BE.SIMPLEPRIVILEGE sp)
        {
            BLLCPSP bLLCPSP = new BLLCPSP();
            bLLCPSP.cpsp.codeP1 = cp;
            bLLCPSP.cpsp.codeP2 = sp;
            bLLCPSP.Remove();
        }
    }
}
