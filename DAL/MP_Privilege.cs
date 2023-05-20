using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_Privilege : MAPPER<BE.PRIVILEGE>
    {
        public override PRIVILEGE Convert(DataRow registry)
        {
            BE.PRIVILEGE priv = new BE.PRIVILEGE();
            priv.Id = int.Parse(registry["ID"].ToString());
            priv.Name = registry["Name"].ToString();
            return priv;
        }

        public override int Delete(PRIVILEGE entity)
        {
            throw new NotImplementedException();
        }

        public override int Edit(PRIVILEGE entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", entity.Id),
                access.CreateParameter("@name", entity.Name),
            };
            access.Open();
            int result = access.Write("EDIT_PARAMETER", parameters);
            access.Close();
            return result;
        }

        public override int Insert(PRIVILEGE entity)
        {
            throw new NotImplementedException();
        }

        public override List<PRIVILEGE> List()
        {
            throw new NotImplementedException();
        }
    }
}