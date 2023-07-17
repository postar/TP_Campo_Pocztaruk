using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class LANGUAJE
    {
        private string languajeName;
        private string description;

        public LANGUAJE(string languajeName, string description)
        {
            this.languajeName = languajeName;
            this.description = description;
        }

        public LANGUAJE()
        {
        }

        public string LanguajeName { get => languajeName; set => languajeName = value; }
        public string Desciption { get => description; set => description = value; }
    }
}