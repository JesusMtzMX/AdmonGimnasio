using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProyectoGimnasio.AppControlador
{
    public class __Conexion
    {

        static MySqlConnection connection;

        public static bool conectar()
        {
            try
            {

                if (connection == null || connection.State != ConnectionState.Open)
                {
                    connection = new MySqlConnection();
                    connection.ConnectionString = "Server=localhost;" +
                    "Database=gimnasio;" +
                    "uid=root;" +
                    "pwd=root;";// sslmode=none";

                    connection.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se puede establecer la conexión con el servidor.");
            }
        }

        public static DataTable ejecutarConsulta(MySqlCommand consulta)
        {
            if (conectar())
            {
                consulta.Connection = connection;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            return null;
        }

        public static int ejecutarSentencia(MySqlCommand sentencia, bool esInsertar)
        {
            int valor = 0;
            if (conectar())
            {
                sentencia.Connection = connection;
                if (esInsertar)
                    valor = int.Parse(sentencia.ExecuteScalar().ToString());
                else
                    valor = sentencia.ExecuteNonQuery();
            }
            return valor;
        }
        public static int ejecutarSelect(MySqlCommand sentencia)
        {
            int valor = 0;
            if (conectar())
            {
                sentencia.Connection = connection;
                valor = int.Parse(sentencia.ExecuteScalar().ToString());
            }
            return valor;
        }
        public static void desconectar()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

    }
}