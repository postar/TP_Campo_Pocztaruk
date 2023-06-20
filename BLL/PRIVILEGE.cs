using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BLL
{
    public class PRIVILEGE
    {
        private BE.PRIVILEGE privilege;

        public BE.PRIVILEGE Privilege
        {
            get { return privilege; }
            set { privilege = value; }
        }
    }
}