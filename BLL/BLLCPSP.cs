using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BLLCPSP
    {
        DAL.MP_CPSP dalCpsp;
        public BE.CPSP cpsp = new BE.CPSP();
        public BLLCPSP()
        {
            dalCpsp = new DAL.MP_CPSP();
        }
        public List<BE.CPSP> List()
        {
            return dalCpsp.List();
        }        
        public void Remove()
        {
            dalCpsp.Delete(cpsp);
        }
        public void Add()
        {
            dalCpsp.Insert(cpsp);
        }
    }
}
