using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.SQLite;
using System.Text;

using System.Security.Cryptography;

namespace SistemaInventarioRopa_Web.Models
{
    public class UserStore : IUserStore<Usuario>, IUserLoginStore<Usuario>, IUserPasswordStore<Usuario>, IUserSecurityStampStore<Usuario>
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        private string ConvContraseniaHash(string pass)
        {
            MD5CryptoServiceProvider MD5Cipher = new MD5CryptoServiceProvider();
            UTF8Encoding encoder = new UTF8Encoding();
            string PasswordHash = Convert.ToBase64String(MD5Cipher.ComputeHash(encoder.GetBytes(pass)));

            return PasswordHash;
        }

        public Task AddLoginAsync(Usuario user, UserLoginInfo login)
        {
            return Task.FromResult(0);
        }

        public Task CreateAsync(Usuario user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            return Task.Factory.StartNew(() =>
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmdNuevoUser = new SQLiteCommand("INSERT INTO Empleados VALUES(NULL, @Nombres, @DUI, @UserType, @Username,@Password, @Fecha)", connection))
                    {
                        connection.Open();
                        cmdNuevoUser.Parameters.AddWithValue("@Nombres", user.NombreCompleto);
                        cmdNuevoUser.Parameters.AddWithValue("@DUI", user.DUI);
                        cmdNuevoUser.Parameters.AddWithValue("@UserType", user.TipoUsuario);
                        cmdNuevoUser.Parameters.AddWithValue("@Password", ConvContraseniaHash(user.PasswordHash));
                        cmdNuevoUser.Parameters.AddWithValue("@Fecha", DateTime.Now);

                        cmdNuevoUser.ExecuteNonQuery();
                    }
                }
            });
        }

        public Task DeleteAsync(Usuario user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            return Task.Factory.StartNew(() =>
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmdBorrarUsuario = new SQLiteCommand("DELETE FROM Empleados WHERE EmpleadosId=@Id", connection))
                    {
                        connection.Open();
                        cmdBorrarUsuario.Parameters.AddWithValue("@Id", user.UserId);
                        cmdBorrarUsuario.ExecuteNonQuery();
                    }
                }
            });
        }

        public Task<Usuario> FindAsync(UserLoginInfo login)
        {
            if (login == null)
                throw new ArgumentNullException("login");

            return Task.Factory.StartNew(() =>
            {
                Usuario user = null;
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Empleados WHERE Username=@user", connection))
                    {
                        connection.Open();
                        cmdConsulta.Parameters.AddWithValue("@user", login.ProviderKey);
                        using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new Usuario();
                                user.UserId = reader.GetInt32(0);
                                user.NombreCompleto = reader.GetString(1);
                                user.DUI = reader.GetString(2);
                                user.TipoUsuario = reader.GetInt32(3);
                                user.UserName = reader.GetString(4);
                                user.PasswordHash = reader.GetString(5);
                                user.FechaCreacion = reader.GetDateTime(6);
                                user.SecurityStamp = Guid.NewGuid().ToString();

                            }
                            reader.Close();
                        }
                    }
                }
                return user;
            });
        }

        public Task<Usuario> FindByIdAsync(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentNullException("userId");

            int id = Convert.ToInt32(userId);
            return Task.Factory.StartNew(() =>
            {
                Usuario user = null;
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Empleados WHERE EmpleadoId =@id", connection))
                    {
                        connection.Open();
                        cmdConsulta.Parameters.AddWithValue("@id", id);
                        using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new Usuario();
                                user.UserId = reader.GetInt32(0);
                                user.NombreCompleto = reader.GetString(1);
                                user.DUI = reader.GetString(2);
                                user.TipoUsuario = reader.GetInt32(3);
                                user.UserName = reader.GetString(4);
                                user.PasswordHash = reader.GetString(5);
                                user.FechaCreacion = reader.GetDateTime(6);
                                user.SecurityStamp = Guid.NewGuid().ToString();

                            }
                            reader.Close();
                        }
                    }
                }
                return user;
            });
        }

        public Task<Usuario> FindByNameAsync(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException("userName");

            return Task.Factory.StartNew(() =>
            {
                Usuario user = null;
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Empleados WHERE Username=@user", connection))
                    {
                        connection.Open();
                        cmdConsulta.Parameters.AddWithValue("@user", userName);
                        using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new Usuario();
                                user.UserId = reader.GetInt32(0);
                                user.NombreCompleto = reader.GetString(1);
                                user.DUI = reader.GetString(2);
                                user.TipoUsuario = reader.GetInt32(3);
                                user.UserName = reader.GetString(4);
                                user.PasswordHash = reader.GetString(5);
                                user.FechaCreacion = reader.GetDateTime(6);
                                user.SecurityStamp = Guid.NewGuid().ToString();
                            }
                            reader.Close();
                        }
                    }
                }
                return user;
            });
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(Usuario user)
        {
            return Task.FromResult<IList<UserLoginInfo>>(null);
        }

        public Task<string> GetPasswordHashAsync(Usuario user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            return Task.FromResult(user.PasswordHash);
        }

        public Task<string> GetSecurityStampAsync(Usuario user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            return Task.FromResult(user.SecurityStamp);
        }

        public Task<bool> HasPasswordAsync(Usuario user)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task RemoveLoginAsync(Usuario user, UserLoginInfo login)
        {
            return Task.FromResult(0);
        }

        public Task SetPasswordHashAsync(Usuario user, string passwordHash)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            user.PasswordHash = passwordHash;

            return Task.FromResult(0);

        }

        public Task SetSecurityStampAsync(Usuario user, string stamp)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            user.SecurityStamp = stamp;
            return Task.FromResult(user.SecurityStamp);
        }

        public Task UpdateAsync(Usuario user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            return Task.Factory.StartNew(() =>
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmdModUsuario = new SQLiteCommand("UPDATE FROM Empleados SET Nombres=@Nombres, DUI=@DUI, TipoUser=@UserType, Username=@Username, Password=@Password WHERE EmpleadoId=@Id", connection))
                    {
                        connection.Open();
                        cmdModUsuario.Parameters.AddWithValue("@Nombres", user.NombreCompleto);
                        cmdModUsuario.Parameters.AddWithValue("@DUI", user.NombreCompleto);
                        cmdModUsuario.Parameters.AddWithValue("@UserType", user.NombreCompleto);
                        cmdModUsuario.Parameters.AddWithValue("@Username", user.NombreCompleto);
                        cmdModUsuario.Parameters.AddWithValue("@Password", user.NombreCompleto);
                        cmdModUsuario.Parameters.AddWithValue("@Id", user.NombreCompleto);
                    }

                }

            });
        }

        public void Dispose()
        {

        }


    }
}