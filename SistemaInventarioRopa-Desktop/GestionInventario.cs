using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace SistemaInventarioRopa_Desktop
{
    public class GestionInventario
    {
        private readonly string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        public GestionInventario()
        {
        }

        public void ObtenerInventario(ref MetroGrid grid)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Vista_Productos", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader(System.Data.CommandBehavior.KeyInfo))
                    { 
                        grid.Rows.Clear();
                        while (reader.Read())
                        {
                            int indice = grid.Rows.Add();

                            grid.Rows[indice].Cells["colCod"].Value = reader.GetInt32(0);

                             var blob = reader.GetBlob(1, true);
                            byte[] rawData = new byte[blob.GetCount()];
                            blob.Read(rawData, blob.GetCount(), 0);
                            MemoryStream memStream = new MemoryStream(rawData, 0, blob.GetCount(), true);
                            Image img = Image.FromStream(memStream);
                            blob.Dispose();

                            grid.Rows[indice].Cells["colImagen"].Value = img;
                            grid.Rows[indice].Cells["colNombre"].Value = reader.GetString(2);
                            grid.Rows[indice].Cells["colMarca"].Value = reader.GetString(3);
                            grid.Rows[indice].Cells["colTalla"].Value = reader.GetString(4);
                            grid.Rows[indice].Cells["colStock"].Value = reader.GetInt32(5);
                            grid.Rows[indice].Cells["colCategoria"].Value = reader.GetString(6);
                            grid.Rows[indice].Cells["colProveedor"].Value = reader.GetString(7);
                            grid.Rows[indice].Cells["colPrecioVenta"].Value = reader.GetDouble(8);
                            grid.Rows[indice].Cells["colPrecioCompra"].Value = reader.GetDouble(9);
                        }
                        reader.Close();
                    }
                }
            }
        }

        public void ObtenerProveedores(ref MetroGrid grid)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Proveedores", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        grid.Rows.Clear();
                        while (reader.Read())
                        {
                            int indice = grid.Rows.Add();

                            grid.Rows[indice].Cells["colCodProveedor"].Value = reader.GetInt32(0);
                            grid.Rows[indice].Cells["colNombreProveedor"].Value = reader.GetString(1);
                            grid.Rows[indice].Cells["colDireccion"].Value = reader.GetString(2);
                            grid.Rows[indice].Cells["colTelefono"].Value = reader.GetString(3);
                            grid.Rows[indice].Cells["colEmail"].Value = reader.GetString(4);
                            grid.Rows[indice].Cells["colRepresentante"].Value = reader.GetString(5);
                        }
                        reader.Close();
                    }
                }
            }
        }

        public Dictionary<string, object> ObtenerDatosPrenda(int cod)
        {
            Dictionary<string, object> datos = new Dictionary<string, object>();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Prendas WHERE PrendaId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader(System.Data.CommandBehavior.KeyInfo))
                    {

                        if (reader.Read())
                        {
                            datos.Add("Imagen", reader.GetBlob(1, true));
                            datos.Add("Nombre", reader.GetString(2));
                            datos.Add("Marca", reader.GetString(3));
                            datos.Add("Stock", reader.GetInt32(4));
                            datos.Add("Talla", reader.GetString(5));
                            datos.Add("Categoria", reader.GetInt32(6));
                            datos.Add("Proveedor", reader.GetInt32(7));
                            datos.Add("PrecioCompra", reader.GetDouble(8));
                            datos.Add("PrecioVenta", reader.GetDouble(9));
                        }
                        reader.Close();
                    }
                }
            }
            return datos;
        }

        public Dictionary<int, string> ObtenerListadoProveedoresNombres()
        {
            Dictionary<int, string> datos = new Dictionary<int, string>();

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Proveedores", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                            datos.Add(reader.GetInt32(0), reader.GetString(1));

                        reader.Close();
                    }

                }
            }
            return datos;

        }

        public void ObtenerDireccionYRepresentante(int cod, out string direccion, out string representante)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT Direccion, Representante FROM Proveedores WHERE ProveedorId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        reader.Read();
                        direccion = reader.GetString(0);
                        representante = reader.GetString(1);
                    }
                }
            }
        }

        public Dictionary<int, string> ObtenerCategorias()
        {
            Dictionary<int, string> datos = new Dictionary<int, string>();

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Prenda_Categoria", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                            datos.Add(reader.GetInt32(0), reader.GetString(1));
                        reader.Close();
                    }
                }
            }
            return datos;
        }

        public bool IngresarNuevaCategoria(string nombre)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdIngresar = new SQLiteCommand("INSERT INTO Prenda_Categoria VALUES(NULL, @Nombre)", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdIngresar.Parameters.AddWithValue("@Nombre", nombre);
                    resultado = (cmdIngresar.ExecuteNonQuery() > 0);
                }
            }
            return resultado;

        }

        public bool AgregarNuevaPrenda(Dictionary<string, object> datos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {

                using (SQLiteCommand cmdInsertar = new SQLiteCommand(
                "INSERT INTO Prendas VALUES(NULL, @Imagen, @Nombre, @Marca, @Stock, @Talla, @Categoria, @Proveedor, @PrecioCompra, @PrecioVenta)",
                conexionSQL))
                {
                    conexionSQL.Open();

                    foreach (var i in datos)
                        cmdInsertar.Parameters.AddWithValue(i.Key, i.Value);

                    resultado = (cmdInsertar.ExecuteNonQuery() > 0);
                }                
            }
            return resultado;
        }

        public bool ActualizarPrenda(Dictionary<string, object> datos)
        {
            bool Resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdActualizar = new SQLiteCommand(
                "UPDATE Prendas SET Imagen=@Imagen, Nombre=@Nombre, Marca=@Marca, Stock=@Stock, Talla=@Talla, Categoria=@Categoria, Proveedor=@Proveedor, PrecioCompra=@PrecioCompra, PrecioVenta=@PrecioVenta WHERE PrendaId=@Id",
                conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteTransaction transaction = conexionSQL.BeginTransaction())
                    {
                        foreach (var i in datos)
                            cmdActualizar.Parameters.AddWithValue(i.Key, i.Value);
                        Resultado = (cmdActualizar.ExecuteNonQuery() > 0);
                        transaction.Commit();
                    }
                }
            }
            return Resultado;
        }

        public void EliminarPrenda(int cod)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {

                using (SQLiteCommand cmdEliminar = new SQLiteCommand("DELETE FROM Prendas WHERE PrendaId=@Id", conexionSQL))
                {
                    conexionSQL.Open();

                    cmdEliminar.Parameters.AddWithValue("@Id", cod);
                    cmdEliminar.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<string, object> ObtenerDatosProveedor(int cod)
        {
            Dictionary<string, object> datos = null;

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Proveedores WHERE ProveedorId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {

                        if (reader.Read())
                        {
                            datos = new Dictionary<string, object> {
                                { "Nombre", reader.GetString(1) },
                                { "Direccion", reader.GetString(2) },
                                { "Telefono", reader.GetString(3) },
                                { "Email", reader.GetString(4) },
                                { "Representante", reader.GetString(5) }
                            };
                        }
                        reader.Close();
                    }
                }
            }
            return datos;
        }

        public bool NuevoProveedor(Dictionary<string, object> datos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {

                using (SQLiteCommand cmdNuevoProv = new SQLiteCommand(
                "INSERT INTO Proveedores VALUES(NULL, @Nombre, @Direccion,@Telefono, @Email, @Representante)"
                , conexionSQL))
                {
                    conexionSQL.Open();

                    foreach (var i in datos)
                        cmdNuevoProv.Parameters.AddWithValue(i.Key, i.Value);

                    resultado = (cmdNuevoProv.ExecuteNonQuery() > 0);
                }
            }
            return resultado;
        }

        public bool ActualizarProveedor(Dictionary<string, object> datos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdActualizar = new SQLiteCommand(
                "UPDATE Proveedores SET Nombre=@Nombre, Direccion=@Direccion, Telefono=@Telefono, Email=@Email, Representante=@Representante WHERE ProveedorId=@Id",
                conexionSQL))
                {
                    conexionSQL.Open();

                    foreach (var i in datos)
                        cmdActualizar.Parameters.AddWithValue(i.Key, i.Value);

                    resultado = (cmdActualizar.ExecuteNonQuery() > 0);
                }

            }
            return resultado;
        }

        public void EliminarProveedor(int cod)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdEliminar = new SQLiteCommand("DELETE FROM Proveedores WHERE ProveedorId=@Id", conexionSQL))
                {
                    conexionSQL.Open();

                    cmdEliminar.Parameters.AddWithValue("@Id", cod);
                    cmdEliminar.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCategoria(int cod)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {

                using (SQLiteCommand cmdEliminar = new SQLiteCommand("DELETE FROM Prenda_Categoria WHERE CatId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdEliminar.Parameters.AddWithValue("@Id", cod);
                    cmdEliminar.ExecuteNonQuery();
                }
            }
        }



    }
}
