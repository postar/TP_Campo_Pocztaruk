using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class MP_PROFILE:MAPPER<BE.PROFILE>
   {
        public override int Insert(BE.PROFILE entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter> 
            {
                access.CreateParameter("@PrivilegeProfile", entity.cp.code),
                access.CreateParameter("@Name", entity.profileName),
            };
            access.Open();
            int result = access.Write("CREATE_PROFILE", parameters);
            access.Close();
            return result;
        }

        public override int Edit(BE.PROFILE entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(BE.PROFILE entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@IdProfile", entity.profileCode),
            };
            access.Open();
            int result = access.Write("DELETE_PROFILE", parameters);
            access.Close();
            return result;
        }

        public override List<BE.PROFILE> List()
        {
            List<BE.PROFILE> profiles = new List<BE.PROFILE>();
            access.Open();
            DataTable table = access.Read("LIST_PROFILES");
            access.Close();
            foreach (DataRow registry in table.Rows)
            {
                profiles.Add(Convert(registry));
            }
            return profiles;
        }

        public override BE.PROFILE Convert(DataRow registry)
        {
            BE.PROFILE profile = new BE.PROFILE();
            profile.profileCode = registry["IdProfile"].ToString();
            profile.profileName = registry["Name"].ToString();
            MP_PRIVILEGE mp = new MP_PRIVILEGE();
            profile.cp = (BE.COMPOSITEPRIVILEGE)mp.GetByID(registry["PrivilegeProfile"].ToString());
            return profile;
        }
        public int AssignProfile(BE.PROFILE entity, BE.USER user)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@Profile", entity.profileCode),
                access.CreateParameter("@UserID", user.Id)
            };
            access.Open();
            int result = access.Write("EDIT_PROFILE", parameters);
            access.Close();
            return result;
        }

        public BE.PROFILE GetByName(string name)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@Name", name)
            };
            access.Open();
            DataTable table = access.Read("GET_PROFILEBYNAME", parameters);
            access.Close();
            return Convert(table.Rows[0]);
        }
    }
}
