using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DBACCESS
    {
        private SqlConnection Connection;
        public void Open()
        {
            Connection = new SqlConnection(@"Data Source=RYZEN-DESKTOP;Initial Catalog=CAMPO;Integrated Security=SSPI");
            Connection.Open();

        }
        public void Close()
        {
            Connection.Close();
            Connection = null;
            GC.Collect();
        }
        private SqlCommand CreateCommand(string sp, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = new SqlCommand(sp, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }
            return cmd;
        }

        public DataTable Read(string sp, List<SqlParameter> parameters = null)
        {
            DataTable table = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = CreateCommand(sp, parameters);
                da.Fill(table);
                da.Dispose();
            }
            return table;
        }

        public int ReadScalar(string sp, List<SqlParameter> parameters = null)
        {
            int result;
            SqlCommand cmd = CreateCommand(sp, parameters);
            try
            {
                result = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            { result = -1; }
            return result;

        }


        public int Write(string sp, List<SqlParameter> parameters = null)
        {
            int result;
            SqlCommand cmd = CreateCommand(sp, parameters);
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = -1;
            }
            return result;

        }

        public SqlParameter CreateParameter(string name, string value)
        {
            SqlParameter parameter = new SqlParameter(name, value);
            parameter.DbType = DbType.String;
            return parameter;
        }

        public SqlParameter CreateParameter(string name, int value)
        {
            SqlParameter parameter = new SqlParameter(name, value);
            parameter.DbType = DbType.Int32;
            return parameter;
        }

        public SqlParameter CreateParameter(string name, float value)
        {
            SqlParameter parameter = new SqlParameter(name, value);
            parameter.DbType = DbType.Single;
            return parameter;
        }
        public SqlParameter CreateParameter(string name, bool value)
        {
            SqlParameter parameter = new SqlParameter(name, value);
            parameter.DbType = DbType.Boolean;
            return parameter;
        }
    }
}
