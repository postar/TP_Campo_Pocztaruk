using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_CPSP : MAPPER<BE.CPSP>
    {
        private List<SqlParameter> LoadParams(BE.CPSP entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (entity.codeP1.code != null)
                parameters.Add(access.CreateParameter("@CP", entity.codeP1.code));
            if (entity.codeP2.code != null)
                parameters.Add(access.CreateParameter("@SP", entity.codeP2.code));
            return parameters;
        }

        public override int Insert(BE.CPSP entity)
        {
            List<SqlParameter> parameters = LoadParams(entity);
            access.Open();
            int result = access.Write("CREATE_CPSP", parameters);
            access.Close();
            return result;
        }

        public override int Edit(BE.CPSP entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(BE.CPSP entity)
        {
            List<SqlParameter> parameters = LoadParams(entity);
            access.Open();
            int result = access.Write("DELETE_CPSP", parameters);
            access.Close();
            return result;
        }

        public override List<BE.CPSP> List()
        {
            List<BE.CPSP> links = new List<BE.CPSP>();
            access.Open();
            DataTable table = access.Read("LIST_CPSP");
            access.Close();
            foreach (DataRow registry in table.Rows)
            {
                links.Add(Convert(registry));
            }
            return links;
        }

        public override BE.CPSP Convert(DataRow registry)
        {
            BE.PRIVILEGE cp = new BE.COMPOSITEPRIVILEGE(registry["CP"].ToString());
            BE.PRIVILEGE sp = new BE.SIMPLEPRIVILEGE(registry["SP"].ToString());
            return new BE.CPSP(registry["CPSP"].ToString(), cp, sp);
        }
    }
}
