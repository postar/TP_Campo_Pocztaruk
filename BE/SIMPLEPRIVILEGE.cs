using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class SIMPLEPRIVILEGE : PRIVILEGE
    {
        public SIMPLEPRIVILEGE(string code) : base(code)
        {
            type = "Simple";
        }

        public override List<PRIVILEGE> ReturnPrivileges()
        {
            return new List<PRIVILEGE>() { this };
        }
    }
}