using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class PROFILE
    {
        private string ProfileCode;
        private string ProfileName;
        private COMPOSITEPRIVILEGE CP;

        public PROFILE(string profileCode, string profileName, COMPOSITEPRIVILEGE cP)
        {
            ProfileCode = profileCode;
            ProfileName = profileName;
            CP = cP;
        }

        public PROFILE()
        {
        }

        public string profileCode { get => ProfileCode; set => ProfileCode = value; }
        public string profileName { get => ProfileName; set => ProfileName = value; }
        public COMPOSITEPRIVILEGE cp { get => CP; set => CP = value; }

        public bool ValidatePrivilege(string _code)
        {
            return CP.ReturnPrivileges().Exists(x => x.code == _code);
        }
    }
}