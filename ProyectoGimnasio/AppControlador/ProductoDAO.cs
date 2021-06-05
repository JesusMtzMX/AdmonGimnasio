using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ProyectoGimnasio.AppModelo;
using MySql.Data.MySqlClient;

namespace ProyectoGimnasio.AppControlador
{
    public class ProductoDAO
    {        
        public List<Producto> getAll()
        {
            try
            {
                List<Producto> lista = new List<Producto>();

                MySqlCommand sentencia = new MySqlCommand();                                

                sentencia.CommandText =
                    "SELECT * FROM productos;"; //cambiar a procedimientos almacenados

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Producto(                       
                       fila["Nombre"].ToString(),
                       fila["Marca"].ToString(),                       
                       fila["Contenido"].ToString(),                       
                       fila["Categoria"].ToString(),                       
                       fila["Descripcion"].ToString(),                       
                       fila["Foto"].ToString(),                       
                       fila["Status"].ToString()
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
        
        /*public List<DatosContacto> getOne(int id_empresa)
        {
            try
            {
                List<DatosContacto> lista = new List<DatosContacto>();

                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText =
                    "SELECT * FROM empresas WHERE id_empresa = @id_empresa;";
                sentencia.Parameters.AddWithValue("@id_empresa", id_empresa);

                DataTable tabla = __Conexion.ejecutarConsulta(sentencia);

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new DatosContacto(

                       Convert.ToInt32(fila["id_empresa"].ToString()),
                       fila["nombre"].ToString(),
                       fila["email"].ToString(),
                       Convert.ToInt32(fila["id_estado"].ToString()),
                       Convert.ToInt32(fila["id_municipio"].ToString()),
                       Convert.ToInt32(fila["codigo_postal"].ToString()),
                       fila["domicilio"].ToString(),
                       fila["giro"].ToString(),
                       fila["sector"].ToString(),
                       fila["telefono"].ToString(),
                       fila["mision"].ToString()
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
        }*/

    }
}