using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PRIVILEGE
    {
        public PRIVILEGE()
        {

        }
        public PRIVILEGE(int i)
        {
            id = i;
        }
        public PRIVILEGE(int i, string n)
        {
            id = i;
            this.name = n;
        }

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
        public virtual bool Validate(PRIVILEGE p)
        {
            return id == p.id;
        }
    }
}
