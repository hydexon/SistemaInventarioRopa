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

namespace SistemaInventarioRopa_Desktop
{
    public partial class FrmEditorProveedor : MetroForm
    {
        GestionInventario inventario;
        private int CodActual = -1;
        private bool Editando = false;

        public FrmEditorProveedor()
        {
            InitializeComponent();
            inventario = new GestionInventario();
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtRepresentante.Clear();
            mtbTelefono.Clear();
        }

        public DialogResult NuevoProveedor()
        {
            Editando = false;
            LimpiarControles();
            Text = "Agregando Proveedor";

            return ShowDialog();
        }
        public DialogResult EditarProveedor(int cod)
        {
            CodActual = cod;
            Editando = true;
            Text = "Editando Proveedor";
            LimpiarControles();

            Dictionary<string, object> datos = inventario.ObtenerDatosProveedor(cod);
            txtNombre.Text = datos["Nombre"].ToString();
            txtDireccion.Text = datos["Direccion"].ToString();
            txtEmail.Text = datos["Telefono"].ToString();
            txtRepresentante.Text = datos["Representante"].ToString();
            mtbTelefono.Text = datos["Telefono"].ToString();

            return ShowDialog();
        }

        private void FrmEditorProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo del nombre del proveedor no puede estar vacio!");
                return;
            }

            if (String.IsNullOrEmpty(txtDireccion.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo de Direccion no puede estar vacio!");
                return;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo de Email de producto no puede estar vacio!");
                return;
            }

            if (String.IsNullOrEmpty(txtRepresentante.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo del Representante no puede estar vacio!");
                return;
            }

            Dictionary<string, object> datos = new Dictionary<string, object> {
                { "@Nombre", txtNombre.Text  },
                { "@Direccion", txtDireccion.Text },
                { "@Email", txtEmail.Text },
                { "@Representante", txtRepresentante.Text },
                { "@Telefono", mtbTelefono.Text },
            };

            if (Editando) datos.Add("@Id", CodActual);
            bool resultado = (Editando ?  inventario.ActualizarProveedor(datos) : inventario.NuevoProveedor(datos));
            DialogResult = (resultado ? DialogResult.OK : DialogResult.Cancel);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
