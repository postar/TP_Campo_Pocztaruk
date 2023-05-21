using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class USER
    {
        private int retries = 0;
        //private BE.USER user = new BE.USER();
        private BE.USER user;

        public BE.USER User
        {
            get { return user; }
            set { user = value; }
        }

        DAL.MP_USER DALuser = new DAL.MP_USER();
        public bool ValidateUser()
        {            
            if (retries < 3)
            {
                BE.USER u = DALuser.GetUserByEmail(user.Email);              
                if (u != null && u.Locked == false)
                {
                    u.Password = Services.ENCRYPTOR.GetSHA256(user.Password);
                    user = u;
                    if (DALuser.ValidatePassword(user.Email, user.Password) != null)
                    {
                        Services.SESSIONMANAGER.Login(user);
                        return true;
                    }
                    else
                    {
                        retries++;
                        throw new Exception("Wrong Password");
                    }
                }
            }
            else
            {
                BE.USER u = DALuser.GetUserByEmail(user.Email);
                DALuser.LockAccount(u);
                retries = 0;
            }
            throw new Exception("User Locked");
        }

        public int AddUser()
        {
            user.Password = Services.ENCRYPTOR.GetSHA256(user.Password);
            return DALuser.Insert(user);
        }
        public int EditUser()
        {
            user.Password = Services.ENCRYPTOR.GetSHA256(user.Password);
            return DALuser.Edit(user);
        }
        public static List<BE.USER> ListUsers()
        {
            DAL.MP_USER mP_USER = new DAL.MP_USER();
            return mP_USER.List();
        }
        public int UnlockUser()
        {
            return DALuser.UnlockAccount(user);
        }
    }
}
