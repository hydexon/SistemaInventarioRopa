using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace SistemaInventarioRopa_Desktop
{
    public partial class FrmEditorPrenda : MetroForm
    {
        private GestionInventario inventario;
        private bool EditandoPrenda = false;
        private int codigoPrenda = -1;

        public FrmEditorPrenda()
        {
            InitializeComponent();
            inventario = new GestionInventario();
        }

        private void FrmEditorPrenda_Load(object sender, EventArgs e)
        {
            if (inventario.ObtenerListadoProveedoresNombres().Count < 1) return;
            if (inventario.ObtenerCategorias().Count < 1) return;

            cbProveedor.DisplayMember = "Value";
            cbProveedor.ValueMember = "Key";
            cbProveedor.DataSource = new BindingSource(inventario.ObtenerListadoProveedoresNombres(), null);

            cbCategoria.DisplayMember = "Value";
            cbCategoria.ValueMember = "Key";
            cbCategoria.DataSource = new BindingSource(inventario.ObtenerCategorias(), null);

        }

        private void LimpiarControles()
        {
            txtNombreProd.Clear();
            txtMarca.Clear();
            numPrecioCompra.Value = 1;
            numPrecioVenta.Value = 1;
            numStock.Value = 0;
            cbTalla.SelectedIndex = -1;
            cbProveedor.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            pictureBox1.Image = null;
        }


        public DialogResult EditarPrenda(int cod)
        {
            EditandoPrenda = true;
            codigoPrenda = cod;
            LimpiarControles();
            Dictionary<string, object> datos = inventario.ObtenerDatosPrenda(codigoPrenda);
            txtNombreProd.Text = datos["Nombre"].ToString();
            txtMarca.Text = datos["Marca"].ToString();
            numPrecioCompra.Value = Convert.ToDecimal(datos["PrecioCompra"]);
            numPrecioVenta.Value = Convert.ToDecimal(datos["PrecioVenta"]);
            numStock.Value = Convert.ToDecimal(datos["Stock"]);
            cbCategoria.SelectedValue = Convert.ToInt32(datos["Categoria"]);
            cbProveedor.SelectedValue = Convert.ToInt32(datos["Proveedor"]);
            cbTalla.SelectedIndex = cbTalla.Items.IndexOf(datos["Talla"]);

            var blob = (System.Data.SQLite.SQLiteBlob)datos["Imagen"];
            byte[] rawData = new byte[blob.GetCount()];
            blob.Read(rawData, blob.GetCount(), 0);
            MemoryStream memStream = new MemoryStream(rawData, 0, blob.GetCount(), false);
            pictureBox1.Image = new Bitmap(memStream);
            blob.Dispose();
            return ShowDialog();
        }

        public DialogResult NuevaPrenda()
        {
            LimpiarControles();
            EditandoPrenda = false;
            return ShowDialog();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreProd.Text)) {
                MetroFramework.MetroMessageBox.Show(this, "El campo del nombre de producto no puede estar vacio!");
                return;
            }

            if (String.IsNullOrEmpty(txtMarca.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo de la marca no puede estar vacio!");
                return;
            }

            MemoryStream imgStream = new MemoryStream();
            pictureBox1.Image.Save(imgStream, pictureBox1.Image.RawFormat);

            Dictionary<string, object> datos = new Dictionary<string, object> {
                { "@Imagen", imgStream.ToArray() },
                { "@Nombre", txtNombreProd.Text  },
                { "@Marca", txtMarca.Text },
                { "@Talla", cbTalla.SelectedItem.ToString() },
                { "@Stock", Convert.ToInt32(numStock.Value) },
                { "@PrecioCompra", numPrecioCompra.Value },
                { "@PrecioVenta", numPrecioVenta.Value },
                { "@Categoria",  cbCategoria.SelectedValue },
                { "@Proveedor",  cbProveedor.SelectedValue }
            };

            if (EditandoPrenda) datos.Add("@Id", codigoPrenda);

            bool resultado = (EditandoPrenda ? inventario.ActualizarPrenda(datos)  :  inventario.AgregarNuevaPrenda(datos));
            DialogResult = (resultado ? DialogResult.OK : DialogResult.Cancel);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abrir Imagen";
                dlg.Filter = "Archivo BMP (*.bmp) | *.bmp | Archivo PNG (*.png) | *.png | Archivo JPEG | *.jpg; *.jpeg | Todos los archivos (*.*) | *.*";

                if(dlg.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }
    }
}
