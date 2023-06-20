using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GROUP : PRIVILEGE
    {
        private List<PRIVILEGE> privileges = new List<PRIVILEGE>();
        public List<PRIVILEGE> Privileges
        {
            get { return privileges; }

        }
        public override bool Validate(PRIVILEGE p)
        {
            bool found = false;
            int i = 0;

            while (i < privileges.Count && !found)
            {
                found = privileges[i].Validate(p);
                i++;
            }
            return found;
        }
    }
}
