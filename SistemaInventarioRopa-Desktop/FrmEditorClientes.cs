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
    public partial class FrmEditorClientes : MetroForm
    {
        GestionCompraVenta clientes;
        private int CodActual = -1;
        private bool Editando = false;

        public FrmEditorClientes()
        {
            InitializeComponent();
            clientes = new GestionCompraVenta();
        }

        public DialogResult NuevoCliente()
        {
            Editando = false;
            LimpiarControles();
            Text = "Agregando Cliente";

            return ShowDialog();

        }

        public DialogResult EditarCliente(int cod)
        {
            CodActual = cod;
            Editando = true;
            Text = "Editando Proveedor";
            LimpiarControles();

            Dictionary<string, object> datos = clientes.ObtenerDatosCliente(cod);
            txtNombres.Text = datos["Nombre"].ToString();
            mtbDUI.Text = datos["DUI"].ToString();
            txtDireccion.Text = datos["Direccion"].ToString();
            mtbTelefono.Text = datos["Telefono"].ToString();
            txtEmail.Text = datos["Email"].ToString();

            return ShowDialog();
        }
        private void LimpiarControles()
        {
            txtEmail.Clear();
            txtNombres.Clear();
            mtbDUI.Clear();
            mtbTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> datos = new Dictionary<string, object> {
                { "@Nombre", txtNombres.Text  },
                { "@Direccion", txtDireccion.Text },
                { "@Email", txtEmail.Text },
                { "@Telefono", mtbTelefono.Text },
                { "@DUI", mtbDUI.Text },
            };
            if (Editando) datos.Add("@Id", CodActual);
            bool resultado = (Editando ? clientes.ActualizarCliente(datos) : clientes.IngresarNuevoCliente(datos));
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
