using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace System_Lf
{
    class User_Datos:Conexion
    {

        public User_Datos()
        { }

        public bool Login(string user, string pass)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuarios where Nombre_Usuario = @user and Contraseña = @contra ";
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@contra", pass);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Cache_Usuario.Id_USER = reader.GetInt32(0);
                            Cache_Usuario.Usuario = reader.GetString(1);
                            Cache_Usuario.Nombre = reader.GetString(3);
                            Cache_Usuario.Apellido = reader.GetString(4);
                            Cache_Usuario.Cargo = reader.GetString(5);
                            Cache_Usuario.Email = reader.GetString(6);
                            Cache_Usuario.Contra = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


    }
}
