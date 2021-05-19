using MySql.Data.MySqlClient;
using ProyectoGimnasio.AppModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoGimnasio.AppControlador
{
    public class AdministradorDAO
    {
        public List<Administrador> getAll()
        {
            try
            {
                List<Administrador> lista = new List<Administrador>();

                MySqlCommand sentencia = new MySqlCommand();

                sentencia.CommandText =
                    "SELECT * FROM administradores;"; //cambiar a procedimientos almacenados

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Administrador(
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
        
        public List<Administrador> getOne(int idAdministrador)
        {
            try
            {
                List<Administrador> lista = new List<Administrador>();

                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText =
                    "SELECT * FROM empresas WHERE idAdministrador = @idAdministrador;";
                sentencia.Parameters.AddWithValue("@idAdministrador", idAdministrador);

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Administrador(
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