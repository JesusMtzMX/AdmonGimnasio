using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoGimnasio.AppModelo;
using MySql.Data.MySqlClient;

namespace ProyectoGimnasio.AppControlador
{
    public class ClienteDAO
    {
        private __Conexion Conn = new __Conexion();

        public Cliente getOne(int idCliente)
        {
            try
            {
                Cliente cliente = new Cliente();

                MySqlCommand sentencia = new MySqlCommand();
                
                sentencia.CommandText =
                    "SELECT * FROM clientes WHERE idCliente = @idCliente;";
                sentencia.Parameters.AddWithValue("@idCliente", idCliente);

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    cliente.idCliente = Convert.ToInt32(fila["idCliente"].ToString());
                    cliente.Nombre = fila["Nombre"].ToString();
                    cliente.Apellidos = fila["Apellidos"].ToString();
                    cliente.Edad = Convert.ToInt32(fila["Edad"].ToString());
                    cliente.Peso = Convert.ToDouble(fila["Peso"].ToString());
                    cliente.Estatura = Convert.ToDouble(fila["Estatura"].ToString());
                    cliente.Foto = fila["Foto"].ToString();
                }
                return cliente;
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