using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class CPSP
    {
        private string CodeCPSP;
        private PRIVILEGE CodeP1;
        private PRIVILEGE CodeP2;

        public CPSP(string codePCPS = null, PRIVILEGE codeP1 = null, PRIVILEGE codeP2 = null)
        {
            CodeCPSP = codePCPS;
            CodeP1 = codeP1;
            CodeP2 = codeP2;
        }

        public string codeCPSP { get => CodeCPSP; set => CodeCPSP = value; }
        public PRIVILEGE codeP1 { get => CodeP1; set => CodeP1 = value; }
        public PRIVILEGE codeP2 { get => CodeP2; set => CodeP2 = value; }
    }
}