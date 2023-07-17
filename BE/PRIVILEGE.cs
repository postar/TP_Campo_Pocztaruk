using System.Collections.Generic;

namespace BE
{
    public abstract class PRIVILEGE
    {

        private string Code;
        private string Type;

        public string code { get => Code; set => Code = value; }
        public string type { get => Type; set => Type = value; }
        public abstract List<PRIVILEGE> ReturnPrivileges();

        public PRIVILEGE(string code)
        {
            this.code = code;
        }
    }
}
