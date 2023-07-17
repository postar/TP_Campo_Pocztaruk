using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using BE;

namespace DAL
{
    public class MP_LOGBOOK: MAPPER<BE.LOGBOOK>
    {

        //public static int ObtenerDigitoVerificador(string str)
        //{
        //    return str.GetHashCode();
        //}

        //public void CargarBitacora(Bitacora bitacora)
        //{
        //    using (var conexion = Conectarse())
        //    {
        //        conexion.Open();
        //        using (var comando = new SqlCommand())
        //        {
        //            int aux;
        //            comando.Connection = conexion;
        //            aux = ObtenerDigitoVerificador(bitacora.usuario+bitacora.accion+bitacora.fecha);
        //            comando.Parameters.AddWithValue("@user", bitacora.usuario);
        //            comando.Parameters.AddWithValue("@hora", bitacora.fecha.ToString());
        //            comando.Parameters.AddWithValue("@accion", bitacora.accion);
        //            comando.Parameters.AddWithValue("@aux", aux);
        //            comando.CommandText = "insert into Bitacora values(@user,@accion,@hora,@aux)";
        //            comando.CommandType = CommandType.Text;
        //            comando.ExecuteNonQuery();
        //            comando.CommandText = "update DigitoVertical set DigitoVerificador = (select sum(DigitoHorizontal) from Bitacora)where Tabla = 'Bitacora'";
        //            comando.CommandType = CommandType.Text;
        //            comando.ExecuteNonQuery();

        //        }
        //    }
        //}

        public override LOGBOOK Convert(DataRow registry)
        {
            throw new NotImplementedException();
        }

        public override int Delete(LOGBOOK entity)
        {
            throw new NotImplementedException();
        }

        public override int Edit(LOGBOOK entity)
        {
            throw new NotImplementedException();
        }

        public override int Insert(LOGBOOK entity)
        {
            throw new NotImplementedException();
        }

        public override List<LOGBOOK> List()
        {
            throw new NotImplementedException();
        }

        /*
       public void AltaBitacoraLogOut(string user, DateTime HoraSalida)
       {
           using (var conexion = Conectarse())
           {
               conexion.Open();
               using (var comando = new SqlCommand())
               {
                   int aux;
                   comando.Connection = conexion;
                   aux = ObtenerDigitoVerificador(user + "Cierre de Sesion Registrado el: " + HoraSalida);
                   comando.CommandText = "insert into Bitacora values('" + user + "','Cierre de Sesion Registrado el: " + HoraSalida + "','" + aux + "')";
                   comando.CommandType = CommandType.Text;
                   comando.ExecuteNonQuery();
                   comando.CommandText = "update DigitoVertical set DigitoVerificador = (select sum(DigitoHorizontal) from Bitacora)where Tabla = 'Bitacora'";
                   comando.CommandType = CommandType.Text;
                   comando.ExecuteNonQuery();
               }
           }
       }
*/
    //    public void UpdateDigitos()
    //    {
    //        using (var conexion = Conectarse())
    //        {
    //            conexion.Open();
    //            var conexion2 = Conectarse();
    //            conexion2.Open();
    //            using (var comando = new SqlCommand())
    //            {
    //                SqlDataAdapter da = new SqlDataAdapter("select * from Bitacora", conexion);
    //                DataTable dt = new DataTable();
    //                da.Fill(dt);
    //                comando.Parameters.Add("@Digito", SqlDbType.Int);
    //                comando.Parameters.Add("@ID", SqlDbType.Int);

    //                for (int i = 0; i < dt.Rows.Count; i++)
    //                {
    //                    int ID = int.Parse (dt.Rows[i]["Id"].ToString());
    //                    string detalle = dt.Rows[i]["Detalle"].ToString();
    //                    string fecha = dt.Rows[i]["Hora"].ToString();
    //                    string Usuario = dt.Rows[i]["Usuario"].ToString();
    //                    string final= string.Concat(Usuario,detalle,fecha);
    //                    int digito = ObtenerDigitoVerificador(final);
    //                    comando.Parameters["@Digito"].Value=digito;
    //                    comando.Parameters["@ID"].Value = ID;
    //                    comando.Connection = conexion2;
    //                    comando.CommandText = "update Bitacora set DigitoHorizontal = @Digito where Id = @ID";
    //                    comando.ExecuteNonQuery();
    //                    comando.CommandText = "update DigitoVertical set DigitoVerificador = (select sum(DigitoHorizontal) from Bitacora)where Tabla = 'Bitacora'";
    //                    comando.CommandType = CommandType.Text;
    //                    comando.ExecuteNonQuery();

    //                }             
    //            }
    //        }
    //    }
    //    public bool VerificarDigito()
    //    {
    //        double DigitoCalculado;
    //        double DigitoGuardado;
    //        using (var conexion = Conectarse())
    //        {
    //            conexion.Open();
    //            using (var comando = new SqlCommand())
    //            {
    //                comando.Connection = conexion;
    //                comando.CommandText = "select sum(DigitoHorizontal)from Bitacora";
    //                SqlDataReader reader = comando.ExecuteReader();
    //                reader.Read();
    //                DigitoCalculado = reader.GetDouble(0);
    //                reader.Close();
    //                comando.CommandText = "select DigitoVerificador from DigitoVertical where Tabla='Bitacora'";
    //                SqlDataReader readeraux = comando.ExecuteReader();
    //                readeraux.Read();
    //                DigitoGuardado = readeraux.GetDouble(0);
    //                if (DigitoGuardado == DigitoCalculado) return true;
    //                else return false;
            

    //            }
    //        }
            

    //    }

    }
}

