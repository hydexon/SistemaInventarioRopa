using System;
using System.Windows.Forms;

namespace SistemaInventarioRopa_Desktop
{
    public partial class FrmBuscarPrendas : MetroFramework.Forms.MetroForm
    {
        private GestionInventario inventario;
        private MetroFramework.Controls.MetroGrid grid;

        public bool EsCompra
        {
            get;
            set;
        }

        public FrmBuscarPrendas(ref MetroFramework.Controls.MetroGrid pGrid)
        {
            InitializeComponent();
            inventario = new GestionInventario();
            grid = pGrid;
            inventario.ObtenerInventario(ref this.InventarioPrendasGrid);

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBuscarPrendas_Load(object sender, EventArgs e)
        {
            
        }

        public void RestaurarStock(int codProd, int stock)
        {
            if (codProd < 0) return;
            if (stock < 1) return;

            foreach(DataGridViewRow row in grid.Rows)
            {
                int cod = Convert.ToInt32(row.Cells["colCod"].Value);
                if(cod == codProd)
                {
                    int stockActual = Convert.ToInt32(row.Cells["colStock"].Value);
                    stockActual += stock;
                    row.Cells["colStock"].Value = stockActual;
                    break;
                }
            }
        }

        private void SeleccionarVenta(ref DataGridViewRow row)
        {
            Console.WriteLine("====== PRODUCTO SELECCIONADO PARA VENTA");
            int cantElegida = Convert.ToInt32(numericUpDown1.Value);
            int stockActual = Convert.ToInt32(row.Cells["colStock"].Value);

            if (stockActual < 1 || stockActual < cantElegida)
            {
                MetroFramework.MetroMessageBox.Show(this, "Este producto no puede ser seleccionado, acaba de agotar las existencias!");
                return;
            }
            int dif = stockActual - cantElegida;

            if (dif > stockActual)
            {
                MetroFramework.MetroMessageBox.Show(this, "No hay suficientes existencias!");
                return;
            }

            System.Windows.Forms.DataGridViewRow rowExi = null;
            foreach (System.Windows.Forms.DataGridViewRow r in grid.Rows)
            {
                if (r.Cells["colCod"].Value == row.Cells["colCod"].Value)
                {
                    rowExi = r;
                    break;
                }
            }

            if (rowExi != null)
            {
                int cantActual = Convert.ToInt32(rowExi.Cells["colCantidad"].Value);
                rowExi.Cells["colCantidad"].Value = cantActual + cantElegida;
                rowExi.Cells["colPU"].Value = row.Cells["colPrecioVenta"].Value;
            }
            else
            {
                int idx = grid.Rows.Add();
                rowExi = grid.Rows[idx];
                rowExi.Cells["colCod"].Value = row.Cells["colCod"].Value;
                rowExi.Cells["colProducto"].Value = row.Cells["colNombre"].Value;
                rowExi.Cells["colMarca"].Value = row.Cells["colMarca"].Value;
                rowExi.Cells["colTalla"].Value = row.Cells["colTalla"].Value;
                rowExi.Cells["colCantidad"].Value = cantElegida;
                rowExi.Cells["colPU"].Value = row.Cells["colPrecioVenta"].Value;
            }

            row.Cells["colStock"].Value = dif;
        }

        private void SeleccionarCompra(ref DataGridViewRow row)
        {
            int cantElegida = Convert.ToInt32(numericUpDown1.Value);
            System.Windows.Forms.DataGridViewRow rowExi = null;
            foreach (System.Windows.Forms.DataGridViewRow r in grid.Rows)
            {
                if (r.Cells["colCod"].Value == row.Cells["colCod"].Value)
                {
                    rowExi = r;
                    break;
                }
            }

            if (rowExi != null)
            {
                rowExi.Cells["colCantidad"].Value = cantElegida;
                rowExi.Cells["colPU"].Value = row.Cells["colPrecioCompra"].Value;
            }
            else
            {
                int idx = grid.Rows.Add();
                rowExi = grid.Rows[idx];
                rowExi.Cells["colCod"].Value = row.Cells["colCod"].Value;
                rowExi.Cells["colProducto"].Value = row.Cells["colNombre"].Value;
                rowExi.Cells["colMarca"].Value = row.Cells["colMarca"].Value;
                rowExi.Cells["colTalla"].Value = row.Cells["colTalla"].Value;
                rowExi.Cells["colCantidad"].Value = cantElegida;
                rowExi.Cells["colPU"].Value = row.Cells["colPrecioCompra"].Value;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (InventarioPrendasGrid.CurrentCell == null)
                return;

            if (numericUpDown1.Value == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione la cantidad de stock que desea ingresar antes de continuar");
                return;
            }

            var row = InventarioPrendasGrid.Rows[InventarioPrendasGrid.CurrentCell.RowIndex];
            if (EsCompra)
                SeleccionarCompra(ref row);
            else
                SeleccionarVenta(ref row);

            Close();
        }

        private void InventarioPrendasGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!EsCompra)
                numericUpDown1.Maximum = Convert.ToInt32(InventarioPrendasGrid.Rows[e.RowIndex].Cells["colStock"].Value);
        }

        private void InventarioPrendasGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!EsCompra)
                numericUpDown1.Maximum = Convert.ToInt32(InventarioPrendasGrid.Rows[e.RowIndex].Cells["colStock"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBuscarPrendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
