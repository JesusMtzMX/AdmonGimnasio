using MySql.Data.MySqlClient;
using ProyectoGimnasio.AppModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppControlador
{
    public class DetalleRutinaDAO
    {

        public DataTable getOne(int idRutina)
        {
            try
            {
                //List<String> lista = new List<DetalleRutina>();

                MySqlCommand sentencia = new MySqlCommand();
                
                sentencia.CommandText =
                    "SELECT GrupoMuscular as 'Músculo', Nombre as 'Ejercicio', d.Series, d.Repeticiones " +
                    "FROM Ejercicios E " +
                    "JOIN detalle_rutina d ON E.idEjercicio = d.idEjercicio " +
                    "WHERE d.idRutina = @idRutina;";
                
                sentencia.Parameters.AddWithValue("@idRutina", idRutina);

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);
                
                return tabla;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                __Conexion.desconectar();
            }
        }

    }
}