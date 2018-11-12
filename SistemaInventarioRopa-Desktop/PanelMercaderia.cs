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
    public partial class PanelMercaderia : UserControl
    {
        private GestionInventario inventario;

        public PanelMercaderia()
        {
            InitializeComponent();
            inventario = new GestionInventario();
        }

        private void PanelMercaderia_Load(object sender, EventArgs e)
        {
            InventarioPrendasGrid.AutoGenerateColumns = false;
            ProveedoresGrid.AutoGenerateColumns = false;
            InventarioPrendasGrid.Update();
            inventario.ObtenerInventario(ref this.InventarioPrendasGrid);
            inventario.ObtenerProveedores(ref this.ProveedoresGrid);
        }

        private bool VerificarProveedoresYCategoriasExistentes()
        {
            if(inventario.ObtenerCategorias().Count == 0)
            {
                //this.Parent.Parent = Este UserControl -> El Panel de FrmPrincipal -> FrmPrincipal
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "No puede agregar una nueva prenda, Debe agregar una categoria primero");
                return false;
            }

            if(inventario.ObtenerListadoProveedoresNombres().Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "No puede agregar una nueva prenda, Debe agregar un proveedor primero");
                metroTabControl1.SelectedIndex = 1;
                return false;
            }

            return true;
        }

        public void NuevaPrenda()
        {
            if(VerificarProveedoresYCategoriasExistentes())
            {
                metroTabControl1.SelectedIndex = 0;
                FrmEditorPrenda prenda = new FrmEditorPrenda();
                if(prenda.NuevaPrenda() == DialogResult.OK)  
                    inventario.ObtenerInventario(ref this.InventarioPrendasGrid);
              
            }
        }

        public void ModificarPrenda()
        {
            if (!VerificarProveedoresYCategoriasExistentes()) return;
            if (InventarioPrendasGrid.SelectedRows.Count > 0)
            {
                metroTabControl1.SelectedIndex = 0;
                int indice = InventarioPrendasGrid.CurrentCell.RowIndex;
                int cod = Convert.ToInt32(InventarioPrendasGrid.Rows[indice].Cells[0].Value);
                FrmEditorPrenda prenda = new FrmEditorPrenda();
                if (prenda.EditarPrenda(cod) == DialogResult.OK)
                    inventario.ObtenerInventario(ref this.InventarioPrendasGrid);
                
            }
        }

        public void EliminarPrenda()
        {
            metroTabControl1.SelectedIndex = 0;
            if (InventarioPrendasGrid.SelectedRows.Count > 0)
            {
                if(MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Esta seguro de eliminar esta prenda?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int indice = InventarioPrendasGrid.CurrentCell.RowIndex;
                    int cod = Convert.ToInt32(InventarioPrendasGrid.Rows[indice].Cells[0].Value);
                    inventario.EliminarPrenda(cod);
                    inventario.ObtenerInventario(ref this.InventarioPrendasGrid);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Seleccione una fila primero antes de continuar!");
            }
        }

        public void NuevoProveedor()
        {
            metroTabControl1.SelectedIndex = 1;
            FrmEditorProveedor nuevoProv = new FrmEditorProveedor();
            if (nuevoProv.NuevoProveedor() == DialogResult.OK)
                inventario.ObtenerProveedores(ref ProveedoresGrid);

        }

        public void EditarProveedor()
        {
            if (ProveedoresGrid.SelectedRows.Count > 0)
            {
                metroTabControl1.SelectedIndex = 1;
                int indice = ProveedoresGrid.CurrentCell.RowIndex;
                int cod = Convert.ToInt32(ProveedoresGrid.Rows[indice].Cells[0].Value);
                FrmEditorProveedor editarProv = new FrmEditorProveedor();
                if (editarProv.EditarProveedor(cod) == DialogResult.OK)
                    inventario.ObtenerProveedores(ref ProveedoresGrid);
            }
        }

        public void EliminarProveedor()
        {
            metroTabControl1.SelectedIndex = 1;
            if (ProveedoresGrid.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Esta seguro de eliminar este proveedor?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int indice = ProveedoresGrid.CurrentCell.RowIndex;
                    int cod = Convert.ToInt32(ProveedoresGrid.Rows[indice].Cells[0].Value);
                    inventario.EliminarProveedor(cod);
                    inventario.ObtenerProveedores(ref this.ProveedoresGrid);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Seleccione una fila primero antes de continuar!");
            }

        }
    }
}
