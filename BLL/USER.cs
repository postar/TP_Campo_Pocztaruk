using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class USER
    {
        public static int AddUser(BE.USER user)
        {
            DAL.MP_USER dalUser = new DAL.MP_USER();
            return dalUser.Insert(user);
        }
        public static BE.USER GetUser(string email)
        {
            DAL.MP_USER user = new DAL.MP_USER();
            return user.GetUserByEmail(email);

        }
    }
}
