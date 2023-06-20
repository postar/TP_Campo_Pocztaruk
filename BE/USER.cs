using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class USER
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private bool locked;

        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }


        private List<PRIVILEGE> privileges = new List<PRIVILEGE>();
        public List<PRIVILEGE> Privileges
        {
            get { return privileges; }

        }

        public bool Validate(PRIVILEGE p)
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
