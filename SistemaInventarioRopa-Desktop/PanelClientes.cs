using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioRopa_Desktop
{
    public partial class PanelClientes : UserControl
    {
        private GestionCompraVenta clientes;

        public PanelClientes()
        {
            InitializeComponent();
            clientes = new GestionCompraVenta();
        }

        public void NuevoCliente()
        {
            FrmEditorClientes editorClientes = new FrmEditorClientes();
            if(editorClientes.NuevoCliente() == DialogResult.OK)
                clientes.ObtenerListaClientes(ref this.metroGrid1);
        }

        public void ModificarCliente()
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                int indice = metroGrid1.CurrentCell.RowIndex;
                int cod = Convert.ToInt32(metroGrid1.Rows[indice].Cells[0].Value);
                FrmEditorClientes editorClientes = new FrmEditorClientes();
                if(editorClientes.EditarCliente(cod) == DialogResult.OK)
                    clientes.ObtenerListaClientes(ref this.metroGrid1);
            }
        }

        public void EliminarCliente()
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Esta seguro de eliminar este cliente?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int indice = metroGrid1.CurrentCell.RowIndex;
                    int cod = Convert.ToInt32(metroGrid1.Rows[indice].Cells[0].Value);
                    clientes.EliminarCliente(cod);
                    clientes.ObtenerListaClientes(ref this.metroGrid1);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Seleccione una fila primero antes de continuar!");
            }
        }

        private void PanelClientes_Load(object sender, EventArgs e)
        {
            clientes.ObtenerListaClientes(ref this.metroGrid1);
        }
    }
}
