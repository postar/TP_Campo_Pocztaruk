using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class COMPOSITEPRIVILEGE : PRIVILEGE
    {

        public List<PRIVILEGE> PrivilegeList;
        List<PRIVILEGE> Aux;
        public COMPOSITEPRIVILEGE(string code) : base(code)
        {
            PrivilegeList = new List<PRIVILEGE>();
            type = "Composite";
        }

        public override List<PRIVILEGE> ReturnPrivileges()
        {
            Aux = new List<PRIVILEGE>();
            Recursive(PrivilegeList);
            return Aux;
        }

        public void Recursive(List<PRIVILEGE> list)
        {
            foreach (PRIVILEGE privilege in list)
            {
                if (privilege is SIMPLEPRIVILEGE)
                {
                    Aux.Add(privilege);
                }
                else
                {
                    Recursive((privilege as COMPOSITEPRIVILEGE).PrivilegeList);
                }
            }
        }
    }
}