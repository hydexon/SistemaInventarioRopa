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
    public partial class FrmBorrarCategoria : MetroForm
    {
        private GestionInventario inventario;
        public FrmBorrarCategoria(ref GestionInventario inv)
        {
            InitializeComponent();
            inventario = inv;
        }

        private void FrmBorrarCategoria_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> categorias = inventario.ObtenerCategorias();
            foreach(var i in categorias)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.Value;
                item.Tag = i.Key;
                metroListView1.Items.Add(item);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(metroListView1.SelectedItems.Count == 0) return;

            ListViewItem item = metroListView1.SelectedItems[0];
            if (item == null) return;

            if (MetroFramework.MetroMessageBox.Show(this, "Esta seguro de borrar esta categoria", 
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                inventario.EliminarCategoria(Convert.ToInt32(item.Tag));
                metroListView1.Items.Remove(item);
            }
        }
    }
}
