using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioRopa_Desktop
{
    public partial class FrmNuevaCategoria : MetroFramework.Forms.MetroForm
    {
        private GestionInventario inventario;
        private Dictionary<int, string> categorias;

        public FrmNuevaCategoria(ref GestionInventario inv)
        {
            InitializeComponent();
            inventario = inv;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            metroLabel1.Visible = false;
            var val = categorias.FirstOrDefault(x => x.Value == txtNuevaCat.Text);
            if(val.Equals(null))
            {
                txtNuevaCat.Clear();
                metroLabel1.Visible = true;
            }

            if (inventario.IngresarNuevaCategoria(txtNuevaCat.Text))
                MetroFramework.MetroMessageBox.Show(this, "La categoria nueva ha sido ingresada!");

        }

        private void FrmNuevaCategoria_Load(object sender, EventArgs e)
        {
            categorias = inventario.ObtenerCategorias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
