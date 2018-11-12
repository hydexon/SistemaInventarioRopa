using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MetroFramework.Controls;

namespace SistemaInventarioRopa_Desktop
{
    public struct DatosProducto
    {
        public int Cod;
        public string Producto;
        public string Marca;
        public string Talla;
        public int Cantidad;
        public double Precio;

        public DatosProducto(int mCod, string mProd, string mMarca, string mTalla, int mCant, double p)
        {
            Cod = mCod;
            Producto = mProd;
            Marca = mMarca;
            Talla = mTalla;
            Cantidad = mCant;
            Precio = p;
        }
    }

    
    public class GestionCompraVenta
    {
        private readonly string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        public int ObtenerUltimoInsert(string tabla, string col)
        {
            int id = 0;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                // Al diablo este no es SQL injection, esta funcion no es usada en datos que son entrados por el usuario.
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT MAX("+ col +") FROM " + tabla, conexionSQL))
                {
                    conexionSQL.Open();
                    var valor = cmdConsulta.ExecuteScalar();
                    if(valor != null)
                        if(valor.ToString() != "")
                            id = int.Parse(valor.ToString());
                }
            }

            return id;
        }

        public void ObtenerListaVentas(ref MetroGrid grid)
        {
            grid.Rows.Clear();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Vista_Ventas", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idx = grid.Rows.Add();
                            grid.Rows[idx].Cells["colCodVenta"].Value = reader.GetInt32(0);
                            grid.Rows[idx].Cells["colFechaVenta"].Value = reader.GetDateTime(1);
                            grid.Rows[idx].Cells["colEmplResponsable"].Value = reader.GetString(6);
                            grid.Rows[idx].Cells["colCliente"].Value = reader.GetString(3);
                        }
                        reader.Close();
                    }
                }
            }
        }

        public void ObtenerListaCompras(ref MetroGrid grid)
        {
            grid.Rows.Clear();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Vista_Compra", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idx = grid.Rows.Add();
                            grid.Rows[idx].Cells["colCodCompra"].Value = reader.GetInt32(0);
                            grid.Rows[idx].Cells["colFechaCompra"].Value = reader.GetDateTime(2);
                            grid.Rows[idx].Cells["colProveedor"].Value = reader.GetString(3);
                            grid.Rows[idx].Cells["colCompraEmplResponsable"].Value = reader.GetString(6);
                        }
                        reader.Close();
                    }
                }
            }
        }

        public void ObtenerListaClientes(ref MetroGrid grid)
        {
            grid.Rows.Clear();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Clientes", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idx = grid.Rows.Add();
                            grid.Rows[idx].Cells["colCodCliente"].Value = reader.GetInt32(0);
                            grid.Rows[idx].Cells["colNombres"].Value = reader.GetString(1);
                            grid.Rows[idx].Cells["colDUI"].Value = reader.GetString(2);
                            grid.Rows[idx].Cells["colDireccion"].Value = reader.GetString(3);
                            grid.Rows[idx].Cells["colTelefono"].Value = reader.GetString(4);
                            grid.Rows[idx].Cells["colEmail"].Value = reader.GetString(5);
                        }
                        reader.Close();
                    }
                }
            }
        }

        public Dictionary<int, string> ObtenerSimpleListaClientes()
        {
            Dictionary<int, string> datos = new Dictionary<int, string>();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Clientes", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while(reader.Read())
                            datos.Add(reader.GetInt32(0), reader.GetString(1));
                        
                        reader.Close();
                    }
                }
            }
            return datos;
        }

        public Dictionary<string, object> ObtenerDatosCliente(int cliente)
        {
            Dictionary<string, object> datos = new Dictionary<string, object>();
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Clientes WHERE ClienteId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", cliente);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            datos = new Dictionary<string, object> {
                                { "Nombre", reader.GetString(1) },
                                { "DUI", reader.GetString(2) },
                                { "Direccion", reader.GetString(3) },
                                { "Telefono", reader.GetString(4) },
                                { "Email", reader.GetString(5) }
                            };
                        }

                        reader.Close();
                    }
                }
            }
            return datos;
        }

        public void DetalleCliente(int cod, out string direccion, out string DUI)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT Direccion, DUI FROM Clientes", conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        reader.Read();
                        direccion = reader.GetString(0);
                        DUI = reader.GetString(1);

                        reader.Close();
                    }
                }
            }
        }

        public bool  IngresarNuevoCliente(Dictionary<string, object> datos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdInsertar = new SQLiteCommand("INSERT INTO Clientes VALUES(NULL, @Nombre, @DUI, @Direccion,@Telefono,@Email)", conexionSQL))
                {
                    conexionSQL.Open();
                    foreach (var i in datos)
                        cmdInsertar.Parameters.AddWithValue(i.Key, i.Value);

                    resultado = (cmdInsertar.ExecuteNonQuery() > 0);
                }
            }
            return resultado;
        }

        public bool ActualizarCliente(Dictionary<string, object> datos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdActualizar = new SQLiteCommand(
                "UPDATE Clientes SET Nombre=@Nombre, Direccion=@Direccion, Telefono=@Telefono, Email=@Email, DUI=@DUI WHERE ClienteId=@Id",
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

        public void EliminarCliente(int cod)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdEliminar = new SQLiteCommand("DELETE FROM Clientes WHERE ClienteId=@Id", conexionSQL))
                {
                    conexionSQL.Open();

                    cmdEliminar.Parameters.AddWithValue("@Id", cod);
                    cmdEliminar.ExecuteNonQuery();
                }
            }
        }

        //Andar llamandolo desde GestionInventario es un desmadre.
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

        public bool ObtenerDetallesCliente(int cod, out string Nombre, out string DUI, out string Direccion)
        {
            bool esValido = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Clientes WHERE ClienteId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            Nombre = reader.GetString(1);
                            DUI = reader.GetString(2);
                            Direccion = reader.GetString(3);
                        }
                        else
                        {
                            Nombre = "<NO DISPONIBLE>";
                            DUI = "0-00000000";
                            Direccion = "<NO DISPONIBLE>";
                            esValido = false;
                        }
                        reader.Close();
                    }

                }
            }
            return esValido;
        }

        public bool IngresarVenta(int codCliente, DateTime fecha, Dictionary<int, int> codProductos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("INSERT INTO Ventas VALUES(NULL, @FechaVenta, @Cliente, @Empleado)", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@FechaVenta", fecha);
                    cmdConsulta.Parameters.AddWithValue("@Cliente", codCliente);
                    cmdConsulta.Parameters.AddWithValue("@Empleado", GestionUsuarios.Instancia.ObtenerCodEmpleadoActual);

                    resultado = cmdConsulta.ExecuteNonQuery() > 0;
                }
            }

            int master_id = ObtenerUltimoInsert("Ventas", "VentaId");

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdInsertar = new SQLiteCommand(conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteTransaction transaction = conexionSQL.BeginTransaction())
                    {
                        foreach(var i in codProductos)
                        {
                            cmdInsertar.CommandText = "INSERT INTO Ventas_Detalle VALUES(NULL, @Venta, @Prenda, @Cantidad)";
                            cmdInsertar.Parameters.AddWithValue("@Venta", master_id);
                            cmdInsertar.Parameters.AddWithValue("@Prenda", i.Key);
                            cmdInsertar.Parameters.AddWithValue("@Cantidad", i.Value);
                            resultado = cmdInsertar.ExecuteNonQuery() > 0;
                        }
                        transaction.Commit();
                    }
                }
            }

            return resultado;
        }

        public bool IngresarCompra(int codProv, DateTime fecha, Dictionary<int, int> codProductos)
        {
            bool resultado = false;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("INSERT INTO Compras VALUES(NULL, @FechaVenta, @Proveedor, @Empleado)", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@FechaVenta", fecha);
                    cmdConsulta.Parameters.AddWithValue("@Proveedor", codProv);
                    cmdConsulta.Parameters.AddWithValue("@Empleado", GestionUsuarios.Instancia.ObtenerCodEmpleadoActual);

                    resultado = cmdConsulta.ExecuteNonQuery() > 0;
                }
            }

            int master_id = ObtenerUltimoInsert("Compras", "CompraId");

            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdInsertar = new SQLiteCommand(conexionSQL))
                {
                    conexionSQL.Open();
                    using (SQLiteTransaction transaction = conexionSQL.BeginTransaction())
                    {
                        foreach (var i in codProductos)
                        {
                            cmdInsertar.CommandText = "INSERT INTO Compras_Detalle VALUES(NULL, @Compra, @Prenda, @Cantidad)";
                            cmdInsertar.Parameters.AddWithValue("@Compra", master_id);
                            cmdInsertar.Parameters.AddWithValue("@Prenda", i.Key);
                            cmdInsertar.Parameters.AddWithValue("@Cantidad", i.Value);
                            resultado = cmdInsertar.ExecuteNonQuery() > 0;
                        }
                        transaction.Commit();
                    }
                }
            }

            return resultado;
        }

        private void ObtenerDetalleVenta(int Cod, ref List<DatosProducto> listaProd)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM VistaDetalle_VentaPrendas WHERE VentaDetalleId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", Cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaProd.Add(
                                new DatosProducto(reader.GetInt32(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetInt32(5),
                                reader.GetDouble(6)));
                        }
                        reader.Close();
                    }
                }
            }

        }

        public void ObtenerRegistroVenta(int Cod, ref List<DatosProducto> listaProd, ref int CodCliente, ref int CodEmpleado, ref DateTime FechaVenta)
        {
            int ventaCod = -1;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Ventas WHERE VentaId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", Cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            ventaCod = reader.GetInt32(0);
                            FechaVenta = reader.GetDateTime(1);
                            CodCliente = reader.GetInt32(2);
                            CodEmpleado = reader.GetInt32(3);
                        }
                        reader.Close();
                    }
                }
            }

            ObtenerDetalleVenta(Cod, ref listaProd);
        }

        private void ObtenerDetalleCompra(int Cod, ref List<DatosProducto> listaProd)
        {
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM VistaDetalle_CompraPrendas WHERE CompraDetalleId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", Cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaProd.Add(
                                new DatosProducto(reader.GetInt32(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetInt32(5),
                                reader.GetDouble(6)));
                        }
                        reader.Close();
                    }
                }
            }

        }


        public void ObtenerRegistroCompra(int Cod, ref List<DatosProducto> listaProd, ref int CodProveedor, ref int CodEmpleado, ref DateTime FechaVenta)
        {
            int CompraCod = -1;
            using (SQLiteConnection conexionSQL = new SQLiteConnection(cadenaConexion))
            {
                using (SQLiteCommand cmdConsulta = new SQLiteCommand("SELECT * FROM Compras WHERE CompraId=@Id", conexionSQL))
                {
                    conexionSQL.Open();
                    cmdConsulta.Parameters.AddWithValue("@Id", Cod);
                    using (SQLiteDataReader reader = cmdConsulta.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CompraCod = reader.GetInt32(0);
                            FechaVenta = reader.GetDateTime(1);
                            CodProveedor = reader.GetInt32(2);
                            CodEmpleado = reader.GetInt32(3);
                        }
                        reader.Close();
                    }
                }
            }

            ObtenerDetalleCompra(Cod, ref listaProd);
        }

    }
}
