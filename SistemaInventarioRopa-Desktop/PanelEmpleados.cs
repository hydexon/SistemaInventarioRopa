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
    public partial class PanelEmpleados : UserControl
    {
        public PanelEmpleados()
        {
            InitializeComponent();
        }

        private void PanelEmpleados_Load(object sender, EventArgs e)
        {
            GestionUsuarios.Instancia.ObtenerListaEmpleados(ref this.metroGrid2);
        }

        public void NuevoEmpleado()
        {
            FrmEditorEmpleados editorEmpleados = new FrmEditorEmpleados();
            if(editorEmpleados.NuevoEmpleado() == DialogResult.OK)
                GestionUsuarios.Instancia.ObtenerListaEmpleados(ref this.metroGrid2);

        }

        public void ModificarEmpleado()
        {
            if (metroGrid2.SelectedRows.Count > 0)
            {
                int indice = metroGrid2.CurrentCell.RowIndex;
                int cod = Convert.ToInt32(metroGrid2.Rows[indice].Cells[0].Value);

                FrmEditorEmpleados editorEmpleados = new FrmEditorEmpleados();
                if (editorEmpleados.EditarEmpleado(cod) == DialogResult.OK)
                    GestionUsuarios.Instancia.ObtenerListaEmpleados(ref this.metroGrid2);
            }
        }

        public void EliminarEmpleado()
        {
            if (metroGrid2.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Esta seguro de eliminar este empleado?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int indice = metroGrid2.CurrentCell.RowIndex;
                    int cod = Convert.ToInt32(metroGrid2.Rows[indice].Cells[0].Value);
                    GestionUsuarios.Instancia.EliminarUsuario(cod);
                    GestionUsuarios.Instancia.ObtenerListaEmpleados(ref this.metroGrid2);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Seleccione una fila primero antes de continuar!");
            }


        }
    }
}
