using MySql.Data.MySqlClient;
using ProyectoGimnasio.AppModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppControlador
{
    public class EntrenadorDAO
    {
        public List<Entrenador> getAll()
        {
            try
            {
                List<Entrenador> lista = new List<Entrenador>();

                MySqlCommand sentencia = new MySqlCommand();

                sentencia.CommandText =
                    "SELECT * FROM entrenadores;"; //cambiar a procedimientos almacenados

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Entrenador(
                       fila["Nombre"].ToString(),
                       fila["Apellidos"].ToString(),
                       fila["Domicilio"].ToString(),
                       fila["Telefono"].ToString(),
                       fila["Foto"].ToString(),
                       int.Parse(fila["idUsuario"].ToString())
                    ));
                }

                return lista;
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

        public List<Entrenador> getOne(int idEntrenador)
        {
            try
            {
                List<Entrenador> lista = new List<Entrenador>();

                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText =
                    "SELECT * FROM entrenadores WHERE idEntrenador = @idEntrenador;";
                sentencia.Parameters.AddWithValue("@idEntrenador", idEntrenador);

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Entrenador(
                       fila["Nombre"].ToString(),
                       fila["Apellidos"].ToString(),
                       fila["Domicilio"].ToString(),
                       fila["Telefono"].ToString(),
                       fila["Foto"].ToString(),
                       int.Parse(fila["idUsuario"].ToString())
                    ));
                }
                return lista;
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