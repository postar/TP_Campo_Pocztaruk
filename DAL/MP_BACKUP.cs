using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_BACKUP: DBACCESS
    {

        //public void GenerateBackup(string route)
        //{
        //    string name = "BackUp " + DateTime.Now.ToString("dd_MM_yyyy") + " Time  " + DateTime.Now.ToString("HH-mm")+".bak";
        //    using (var conexion = Conectarse())
        //    {
        //        conexion.Open();
        //        using (var comando = new SqlCommand())
        //        {
        //            comando.Connection = conexion;
        //            comando.CommandText= "BACKUP DATABASE [TC1 Carmona] TO  DISK = N'" + route +"\\"+ name + "'WITH NOFORMAT, NOINIT,  NAME = N'LogIn-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public void Restore(string ruta)
        //{
        //    using (var conexion = Conectarse())
        //    {
        //        conexion.Open();
        //        using (var comando = new SqlCommand())
        //        {
        //            comando.Connection = conexion;
        //            comando.CommandText = "ALTER DATABASE [TC1 Carmona] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
        //            comando.ExecuteNonQuery();
        //            comando.CommandText = "USE MASTER RESTORE DATABASE [TC1 Carmona] FROM DISK='"+ruta+"' WITH REPLACE";
        //            comando.ExecuteNonQuery();
        //            comando.CommandText = "ALTER DATABASE [TC1 Carmona] SET MULTI_USER";
        //            comando.ExecuteNonQuery();

        //        }
        //    }
        //}



    }
}
