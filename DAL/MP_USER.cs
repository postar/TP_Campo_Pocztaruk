using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;

namespace DAL
{
    public class MP_USER : MAPPER<BE.USER>
    {
        public override BE.USER Convert(DataRow registry)
        {
            BE.USER user = new BE.USER();
            user.Id = int.Parse(registry["ID"].ToString());
            user.Email = registry["Email"].ToString();
            user.Name = registry["Name"].ToString();
            //user.Password = registry["Password"].ToString();
            user.Locked = bool.Parse(registry["Locked"].ToString());
            return user;
        }

        public override int Delete(BE.USER entity)
        {
            throw new NotImplementedException();
        }

        public override int Edit(BE.USER entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", entity.Id),
                access.CreateParameter("@name", entity.Name),
                access.CreateParameter("@email", entity.Email),
                access.CreateParameter("@locked", entity.Locked),
                access.CreateParameter("@password", entity.Password),
            };
            access.Open();
            int result = access.Write("EDIT_USER", parameters);
            access.Close();
            return result;
        }

        public override int Insert(BE.USER entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@name", entity.Name),
                access.CreateParameter("@email", entity.Email),
                access.CreateParameter("@password", entity.Password),
            };
            access.Open();
            int result = access.Write("ADD_USER", parameters);
            access.Close();
            return result;
        }

        public override List<BE.USER> List()
        {
            access.Open();
            DataTable table = access.Read("USERS_LIST");
            access.Close();

            List<BE.USER> USERS = new List<BE.USER>();
            foreach (DataRow registry in table.Rows)
            {
                USERS.Add(Convert(registry));
            }
            return USERS;
        }

        public BE.USER GetUserByEmail(string Email)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@email", Email),
            };
            access.Open();
            DataTable table = access.Read("GET_USER",parameters);
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);

        }
    }
}