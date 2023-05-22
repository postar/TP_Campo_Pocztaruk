using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SESSIONMANAGER
    {
        private static object locked = new Object();

        private static SESSIONMANAGER session;
        public BE.USER user { get; set; }

        public static SESSIONMANAGER GetSession
        {
            get
            {
                if (session == null)
                {
                    session = new SESSIONMANAGER();
                }

                return session;
            }
        }

        public bool IsLoggedIn => user != null;

        public static void Login(BE.USER user)
        {
            lock (locked)
            {
                if (session == null)
                {
                    session = new SESSIONMANAGER();
                    session.user = user;
                }
                else
                {
                    throw new Exception("Session in progress");
                }
            }
        }

        public static void Logout()
        {
            lock (locked)
            {
                if (session != null)
                {
                    session = null;
                }
                else
                {
                    throw new Exception("No session in course");
                }
            }
        }
    }
}
