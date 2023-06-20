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
                access.CreateParameter("@UserID", entity.Id),
                access.CreateParameter("@Name", entity.Name),
                access.CreateParameter("@Email", entity.Email),
                access.CreateParameter("@locked", 0),
                access.CreateParameter("@Password", entity.Password),
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
                access.CreateParameter("@Name", entity.Name),
                access.CreateParameter("@Email", entity.Email),
                access.CreateParameter("@Password", entity.Password),
            };
            access.Open();
            int result = access.Write("CREATE_USER", parameters);
            access.Close();
            return result;
        }

        public override List<BE.USER> List()
        {
            access.Open();
            DataTable table = access.Read("LIST_USERS");
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
        public BE.USER GetUserById(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@id", id),
            };
            access.Open();
            DataTable table = access.Read("GET_USERBYID", parameters);
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);
        }

        public bool ValidatePassword(BE.USER entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@Email", entity.Email),
                access.CreateParameter("@Password", entity.Password),
            };
            access.Open();
            DataTable table = access.Read("VALIDATE_USER", parameters);
            access.Close();
            if (table.Rows.Count == 0) { return false; }
            return true;
        }
        public int LockAccount(BE.USER entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@UserID", entity.Id),
            };
            access.Open();
            int result = access.Write("LOCK_USER", parameters);
            access.Close();
            return result;
        }
        public int UnlockAccount(BE.USER entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@UserID", entity.Id),
            };
            access.Open();
            int result = access.Write("UNLOCK_USER", parameters);
            access.Close();
            return result;
        }
    }
}