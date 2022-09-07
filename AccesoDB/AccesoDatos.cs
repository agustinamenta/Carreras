using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NuevasCarrerasApp1.AccesoDB
{
    internal class AccesoDatos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        string cadenaConexion = @"Data Source=AGUSTINA_MENTA\SQLEXPRESS;Initial Catalog=CarrerasDB;Integrated Security=True";
        public DataTable consultarDB(string NombreSP)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
}
