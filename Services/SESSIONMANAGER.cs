using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SESSIONMANAGER
    {
        private static object _lock = new Object();

        private static SESSIONMANAGER _session;
        public BE.USER user { get; set; }

        public static SESSIONMANAGER GetSession
        {
            get
            {
                if (_session == null)
                {
                    _session = new SESSIONMANAGER();
                }

                return _session;
            }
        }

        public bool IsLoggedIn => user != null;

        public static void Login(BE.USER user)
        {
            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new SESSIONMANAGER();
                    _session.user = user;
                }
                else
                {
                    throw new Exception("Session in progress");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("No session in course");
                }
            }
        }
    }
}
