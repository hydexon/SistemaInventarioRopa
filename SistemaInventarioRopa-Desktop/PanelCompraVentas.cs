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
    public partial class PanelCompraVentas : UserControl
    {
        private GestionCompraVenta gestionCV;
        public PanelCompraVentas()
        {
            InitializeComponent();
            gestionCV = new GestionCompraVenta();
        }

        private void PanelCompraVentas_Load(object sender, EventArgs e)
        {
            gestionCV.ObtenerListaCompras(ref this.ComprasGrid);
            gestionCV.ObtenerListaVentas(ref this.VentasGrid);
        }

        public void RegistrarCompra()
        {
            metroTabControl1.TabIndex = 1;
            FrmCompra compra = new FrmCompra(true);
            if(compra.ShowDialog() == DialogResult.OK)
                gestionCV.ObtenerListaCompras(ref this.ComprasGrid);
        }

        public void RegistrarVenta()
        {
            metroTabControl1.TabIndex = 0;
            FrmVenta venta = new FrmVenta(true);
            if(venta.ShowDialog() == DialogResult.OK)
                gestionCV.ObtenerListaVentas(ref this.VentasGrid);
        }

        public void DetallesCompra()
        {
            metroTabControl1.TabIndex = 1;
            if (ComprasGrid.CurrentCell == null)
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Seleccione un registro de Compra primero");
                return;
            }

            int row = ComprasGrid.CurrentCell.RowIndex;
            int cod = Convert.ToInt32(ComprasGrid.Rows[row].Cells["colCodCompra"].Value);
            FrmCompra compra = new FrmCompra(false);
            compra.CargarCompra(cod);
            compra.ShowDialog();
        }

        public void DetallesVenta()
        {
            metroTabControl1.TabIndex = 0;
            if (VentasGrid.CurrentCell == null)
            {
                MetroFramework.MetroMessageBox.Show(this.Parent.Parent, "Seleccione un registro de Venta primero");
                return;
            }

            int row = VentasGrid.CurrentCell.RowIndex;
            int cod = Convert.ToInt32(VentasGrid.Rows[row].Cells["colCodVenta"].Value);
            FrmVenta venta = new FrmVenta(false);
            venta.CargarVenta(cod);
            venta.ShowDialog();
        }
    }
}
