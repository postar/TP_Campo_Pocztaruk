using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_PRIVILEGE : MAPPER<BE.PRIVILEGE>
    {
        private List<SqlParameter> LoadParams(BE.PRIVILEGE entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (entity.code != null)
                parameters.Add(access.CreateParameter("@IdPrivilege", entity.code));
            if (entity.type != null)
                parameters.Add(access.CreateParameter("@Type", entity.type));
            return parameters;
        }

        public override int Insert(BE.PRIVILEGE entity)
        {
            List<SqlParameter> parameters = LoadParams(entity);
            access.Open();
            int result = access.Write("CREATE_PRIVILEGE", parameters);
            access.Close();
            return result;
        }

        public override int Edit(BE.PRIVILEGE entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(BE.PRIVILEGE entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@IdPrivilege", entity.code)
            };
            access.Open();
            int result = access.Write("DELETE_PRIVILEGE", parameters);
            access.Close();
            return result;
        }

        public override List<BE.PRIVILEGE> List()
        {
            List<BE.PRIVILEGE> pRIVILEGEs = new List<BE.PRIVILEGE>();
            access.Open();
            DataTable table = access.Read("LIST_PRIVILEGES");
            access.Close();
            foreach (DataRow registry in table.Rows)
            {
                pRIVILEGEs.Add(Convert(registry));
            }
            return pRIVILEGEs;
        }

        public override BE.PRIVILEGE Convert(DataRow registry)
        {
            BE.PRIVILEGE result;
            if(registry["Type"].ToString() == "Composite")
            {
                result = new BE.COMPOSITEPRIVILEGE(registry["IdPrivilege"].ToString());
            }
            else
            {
                result = new BE.SIMPLEPRIVILEGE(registry["IdPrivilege"].ToString());
            }
            return result;
        }

        public BE.PRIVILEGE GetByID(string idPrivilege)
        {
            List<SqlParameter> parameters = new List<SqlParameter>() 
            {
                access.CreateParameter("@IdPrivilege", idPrivilege)
            };
            access.Open();
            DataTable table = access.Read("GET_PRIVILEGEBYID", parameters);
            access.Close();         
            return Convert(table.Rows[0]);
        }

        public List<BE.PRIVILEGE> GetByType(string type)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@Type", type)
            };
            List<BE.PRIVILEGE> pRIVILEGEs = new List<BE.PRIVILEGE>();
            access.Open();
            DataTable table = access.Read("GET_PRIVILEGEBYTYPE",parameters);
            access.Close();
            foreach (DataRow registry in table.Rows)
            {
                pRIVILEGEs.Add(Convert(registry));
            }
            return pRIVILEGEs;
        }
    }
}

