using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<USUARIO> Listar()
        {
            List<USUARIO> lista = new List<USUARIO>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdUsuario, Nombre, Correo, Telefono, UsuarioIngreso, FechaIngreso, UsuarioModifico, FechaModifico from Catalogo.USUARIO";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new USUARIO()
                                {
									IdUsuario = dr["IdUsuario"] != DBNull.Value ? Convert.ToInt32(dr["IdUsuario"]) : 0,
									Nombre = dr["Nombre"] != DBNull.Value ? dr["Nombre"].ToString() : string.Empty,
									Correo = dr["Correo"] != DBNull.Value ? dr["Correo"].ToString() : string.Empty,
									Telefono = dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : string.Empty,
									UsuarioIngreso = dr["UsuarioIngreso"] != DBNull.Value ? dr["UsuarioIngreso"].ToString() : string.Empty,
									FechaIngreso = dr["FechaIngreso"] != DBNull.Value ? Convert.ToDateTime(dr["FechaIngreso"]) : DateTime.MinValue,
									UsuarioModifico = dr["UsuarioModifico"] != DBNull.Value ? dr["UsuarioModifico"].ToString() : string.Empty,
									FechaModifico = dr["FechaModifico"] != DBNull.Value ? Convert.ToDateTime(dr["FechaModifico"]) : DateTime.MinValue
								});
                        }

                    }
                }
            }
			catch (Exception ex)
			{
				// Agregar logging para capturar excepciones
				Console.WriteLine("Error: " + ex.Message);
				lista = new List<USUARIO>();
			}

			return lista;
        }
    }
}
