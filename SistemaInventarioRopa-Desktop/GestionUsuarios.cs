using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SQLite;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace SistemaInventarioRopa_Desktop
{
    public sealed class GestionUsuarios
    {
        private static readonly GestionUsuarios _instancia = new GestionUsuarios();

        private readonly string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        private MD5CryptoServiceProvider encripcionMD5;


        public static GestionUsuarios Instancia
        {
            get
            {
                return _instancia;
            }
        }

        public GestionUsuarios()
        {
            encripcionMD5 = new MD5CryptoServiceProvider();
        }

        private void GenerarCuentaAdmin()
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                UTF8Encoding encoder = new UTF8Encoding();
                byte[] hashedBytes = encripcionMD5.ComputeHash(encoder.GetBytes("Admin"));
                using (SQLiteCommand cmdCrearUsuario = new SQLiteCommand("INSERT INTO Empleados VALUES(NULL, 'Administrador','99999999-9', 0, 'Admin', @Pass, @Creacion)", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdCrearUsuario.Parameters.Clear();
                    cmdCrearUsuario.Parameters.AddWithValue("@Pass", System.Convert.ToBase64String(hashedBytes));
                    cmdCrearUsuario.Parameters.AddWithValue("@Creacion", DateTime.Now);
                    cmdCrearUsuario.ExecuteNonQuery();
                }
            }
        }

        public void GenerarCuentaAdminPorDefecto()
        {
            bool vacio;

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdVerificarNumUsuarios = new SQLiteCommand("SELECT COUNT(Username) FROM Empleados", conexionSQL))
                {
                    conexionSQL.Open();

                    using (SQLiteDataReader reader = cmdVerificarNumUsuarios.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        reader.Read();
                        vacio = reader.GetInt32(0) == 0;
                        reader.Close();
                    }
                }
            }

            if (vacio)
                GenerarCuentaAdmin();
        }

        public bool VerificarLogin(string Username, string Password)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                UTF8Encoding encoder = new UTF8Encoding();
                string PasswordHash = Convert.ToBase64String(encripcionMD5.ComputeHash(encoder.GetBytes(Password)));

                using (SQLiteCommand cmdVerifcarUsuarios = new SQLiteCommand("SELECT * FROM Empleados WHERE Username=@user", conexionSQL))
                {
                    conexionSQL.Open();

                    cmdVerifcarUsuarios.Parameters.Clear();
                    cmdVerifcarUsuarios.Parameters.AddWithValue("@user", Username);
                    using (SQLiteDataReader reader = cmdVerifcarUsuarios.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        if (reader.Read())
                        {
                            if (reader["Password"].ToString() == PasswordHash)
                            {
                                ObtenerNombreEmpleadoActual = reader["Nombres"].ToString();
                                ObtenerUsernameActual = reader["Username"].ToString();
                                ObtenerCodEmpleadoActual = Convert.ToInt32(reader["EmpleadoId"]);
                                SesionExistente = true;
                                resultado = true;
                                UsuarioActualEsAdmin = (reader.GetInt32(3) == 0 ? true : false);
                                return true;
                            }
                        }
                        reader.Close();
                    }
                }
                return resultado;
            }
        } 

        public void ObtenerListaEmpleados(ref MetroGrid grid)
        {
            grid.Rows.Clear();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Empleados", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int idx = grid.Rows.Add();
                            grid.Rows[idx].Cells["colCod"].Value = reader.GetInt32(0);
                            grid.Rows[idx].Cells["colNombreCompleto"].Value = reader.GetString(1);
                            grid.Rows[idx].Cells["colDUI"].Value = reader.GetString(2);
                            grid.Rows[idx].Cells["colTipoUsuario"].Value = reader.GetInt32(3);
                            grid.Rows[idx].Cells["colNombreUsuario"].Value = reader.GetString(4);
                            grid.Rows[idx].Cells["colFechaCreacion"].Value = reader.GetDateTime(6);
                        }

                        reader.Close();
                    }
                }
            }
        }

        public Dictionary<string, object> ObtenerEmpleado(int cod)
        {
            Dictionary<string, object> datos = new Dictionary<string, object>();

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Empleados WHERE EmpleadoId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add("Nombre", reader.GetString(1));
                            datos.Add("DUI", reader.GetString(2));
                            datos.Add("TipoUser", reader.GetInt32(3));
                            datos.Add("Username", reader.GetString(4));
                        }
                        reader.Close();
                    }
                }
            }
            return datos;
        }


        public bool CrearNuevoUsuario(Dictionary<string, object> datos)
        {
            bool resultado = false;
            //Primero convertir el password en un hash base64.
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] hashedBytes = encripcionMD5.ComputeHash(encoder.GetBytes(datos["@Password"].ToString()));
            datos["@Password"] = Convert.ToBase64String(hashedBytes);

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdNuevoUsuario = new SQLiteCommand("INSERT INTO Empleados VALUES(NULL, @Nombres, @DUI, @UserType, @Username,@Password, @Fecha)", conexionSQL))
                {
                    conexionSQL.Open();
                    foreach (var i in datos)
                        cmdNuevoUsuario.Parameters.AddWithValue(i.Key, i.Value);

                    cmdNuevoUsuario.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    resultado = (cmdNuevoUsuario.ExecuteNonQuery() > 0);
                }
            }
            return resultado;
        }

        public bool ModificarUsuario(Dictionary<string, object> datos)
        {
            bool resultado = false;
            //Primero convertir el password en un hash base64.
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] hashedBytes = encripcionMD5.ComputeHash(encoder.GetBytes(datos["@Password"].ToString()));
            datos["@Password"] = Convert.ToBase64String(hashedBytes);

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                string updateSQL;
                if (datos.ContainsKey("@Password"))
                    updateSQL = "UPDATE FROM Empleados SET Nombres=@Nombres, DUI=@DUI, TipoUser=@UserType, Username=@Username, Password=@Password WHERE EmpleadoId=@Id";
                else
                    updateSQL = "UPDATE FROM Empleados SET Nombres=@Nombres, DUI=@DUI, TipoUser=@UserType, Username=@Username WHERE EmpleadoId=@Id";

                using (SQLiteCommand cmdModUsuario = new SQLiteCommand(updateSQL, conexionSQL))
                {
                    conexionSQL.Open();
                    foreach (var i in datos)
                        cmdModUsuario.Parameters.AddWithValue(i.Key, i.Value);

                    resultado = (cmdModUsuario.ExecuteNonQuery() > 0);
                }
            }

            return resultado;
        }

        public void EliminarUsuario(int cod)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdBorrarUsuario = new SQLiteCommand("DELETE FROM Empleados WHERE EmpleadosId=@Id", conexionSQL))
                {
                    cmdBorrarUsuario.Parameters.AddWithValue("@Id", cod);
                    cmdBorrarUsuario.ExecuteNonQuery();
                }
            }
        }



        // Propiedades Automaticas
        public bool SesionExistente { get; private set; } = false;
        public string ObtenerUsernameActual { get; private set; }
        public string ObtenerNombreEmpleadoActual { get; private set; }
        public bool UsuarioActualEsAdmin { get; private set; }
        public int ObtenerCodEmpleadoActual { get; private set; }

    }
}
