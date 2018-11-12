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
    public partial class FrmCompra : MetroForm
    {
        private GestionInventario inventario = new GestionInventario();
        private GestionCompraVenta Compras = new GestionCompraVenta();
        private FrmBuscarPrendas busqPrendas;
        private bool esNueva;

        public FrmCompra(bool nuevo)
        {
            InitializeComponent();
            busqPrendas = new FrmBuscarPrendas(ref this.metroGrid1);
            busqPrendas.EsCompra = true;
            txtEmpleadoResponsable.Text = GestionUsuarios.Instancia.ObtenerNombreEmpleadoActual;
            esNueva = nuevo;

            if (!esNueva)
                btnRegistrar.Visible = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void CalcularPrecios()
        {
            double precios = 0.0;
            foreach(DataGridViewRow row in metroGrid1.Rows)
            {
                double precioUnitario = Convert.ToDouble(row.Cells["colPU"].Value);
                double cantidadStock = Convert.ToDouble(row.Cells["colCantidad"].Value);

                double prodPT = precioUnitario * cantidadStock;
                precios += prodPT;
            }

            txtSubtotal.Text = precios.ToString();
            double IVA = precios * 0.13;
            txtIva.Text = IVA.ToString();
            double PrecioTotal = precios + IVA;
            txtTotal.Text = PrecioTotal.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentCell == null) return;

            var row = metroGrid1.Rows[metroGrid1.CurrentCell.RowIndex];

            metroGrid1.Rows.Remove(row);

        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            if (inventario.ObtenerListadoProveedoresNombres().Count < 1) return;

            cbProveedor.DisplayMember = "Value";
            cbProveedor.ValueMember = "Key";
            cbProveedor.DataSource = new BindingSource(inventario.ObtenerListadoProveedoresNombres(), null);

            if (esNueva)
            {
                int cod = Compras.ObtenerUltimoInsert("Compras", "CompraId");
                cod++;
                txtCodVenta.Text = cod.ToString();
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string direccion, representante;
            inventario.ObtenerDireccionYRepresentante(Convert.ToInt32(cbProveedor.SelectedValue),out direccion, out representante);
            txtDireccion.Text = direccion;
            txtRepresentante.Text = representante;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            busqPrendas.ShowDialog();
            CalcularPrecios();
        }

        public void CargarCompra(int cod)
        {
            txtCodVenta.Text = cod.ToString();

            int codProv = -1;
            int codEmpleado = -1;
            DateTime fechaCompra = DateTime.Now;
            List<DatosProducto> listaDetalle = new List<DatosProducto>();
            Compras.ObtenerRegistroCompra(cod, ref listaDetalle, ref codProv, ref codEmpleado, ref fechaCompra);

            cbProveedor.SelectedValue = codProv;
            var datosEmpleado = GestionUsuarios.Instancia.ObtenerEmpleado(codEmpleado);
            txtEmpleadoResponsable.Text = datosEmpleado["Nombre"].ToString();
            metroDateTime1.Value = fechaCompra;

            foreach (var i in listaDetalle)
            {
                int idx = metroGrid1.Rows.Add();
                metroGrid1.Rows[idx].Cells["colCod"].Value = i.Cod;
                metroGrid1.Rows[idx].Cells["colProducto"].Value = i.Producto;
                metroGrid1.Rows[idx].Cells["colMarca"].Value = i.Marca;
                metroGrid1.Rows[idx].Cells["colTalla"].Value = i.Talla;
                metroGrid1.Rows[idx].Cells["colPU"].Value = i.Precio;
                metroGrid1.Rows[idx].Cells["colCantidad"].Value = i.Cantidad;
            }

            CalcularPrecios();
        }

        private void FrmCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            busqPrendas.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (esNueva)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            Dictionary<int, int> productos = new Dictionary<int, int>();
            //Asumiendo que el key es unico (cod. de Producto) no creo que puede ser sobreescrito.
            foreach(DataGridViewRow row in metroGrid1.Rows)
            {
                int codProd = Convert.ToInt32(row.Cells["colCod"].Value);
                int numCant = Convert.ToInt32(row.Cells["colCantidad"].Value);
                productos.Add(codProd, numCant);
            }

            bool resultado = Compras.IngresarCompra(Convert.ToInt32(cbProveedor.SelectedValue), metroDateTime1.Value, productos);
            if (resultado)
                MetroFramework.MetroMessageBox.Show(this,"La compra ha sido registrado satisfactoriamente");

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
