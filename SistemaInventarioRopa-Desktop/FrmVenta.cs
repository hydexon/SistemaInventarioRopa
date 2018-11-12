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
    public partial class FrmVenta : MetroForm
    {
        private GestionCompraVenta Ventas = new GestionCompraVenta();
        private FrmBuscarPrendas busqPrendas;
        private bool esNueva;

        public FrmVenta(bool nueva)
        {
            InitializeComponent();
            busqPrendas = new FrmBuscarPrendas(ref this.metroGrid1);
            busqPrendas.EsCompra = false;
            esNueva = nueva;

            if (!esNueva)
                btnRegistrar.Visible = false;
        }

        private void CalcularPrecios()
        {
            double precios = 0.0;
            foreach (DataGridViewRow row in metroGrid1.Rows)
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


        public void CargarVenta(int cod)
        {
            txtCodVenta.Text = cod.ToString();

            int codCliente = -1;
            int codEmpleado = -1;
            DateTime fechaCompra = DateTime.Now;
            List<DatosProducto> listaDetalle = new List<DatosProducto>();
            Ventas.ObtenerRegistroVenta(cod, ref listaDetalle, ref codCliente, ref codEmpleado, ref fechaCompra);

            cbCliente.SelectedValue = codCliente;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            txtEmpleadoResponsable.Text = GestionUsuarios.Instancia.ObtenerNombreEmpleadoActual;
            if (Ventas.ObtenerSimpleListaClientes().Count < 1) return;

            cbCliente.DisplayMember = "Value";
            cbCliente.ValueMember = "Key";
            cbCliente.DataSource = new BindingSource(Ventas.ObtenerSimpleListaClientes(), null);

            if (esNueva)
            {
                int cod = Ventas.ObtenerUltimoInsert("Ventas", "VentaId");
                cod++;
                txtCodVenta.Text = cod.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            busqPrendas.ShowDialog();
            CalcularPrecios();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DUI, Direccion, Nombre;
            Ventas.ObtenerDetallesCliente(Convert.ToInt32(cbCliente.SelectedValue),out Nombre, out DUI, out Direccion);
            txtDireccion.Text = Direccion;
            txtDUI.Text = DUI; 
        }

        private void FrmVenta_FormClosed(object sender, FormClosedEventArgs e)
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
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                int codProd = Convert.ToInt32(row.Cells["colCod"].Value);
                int numCant = Convert.ToInt32(row.Cells["colCantidad"].Value);
                productos.Add(codProd, numCant);
            }

            bool resultado = Ventas.IngresarVenta(Convert.ToInt32(cbCliente.SelectedValue), metroDateTime1.Value, productos);
            if (resultado)
                MetroFramework.MetroMessageBox.Show(this, "La venta ha sido registrado satisfactoriamente");

            DialogResult = (resultado ? DialogResult.OK : DialogResult.Cancel);
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentCell == null) return;

            var row = metroGrid1.Rows[metroGrid1.CurrentCell.RowIndex];

            int cod = Convert.ToInt32(row.Cells["colCod"].Value);
            int cant = Convert.ToInt32(row.Cells["colStock"].Value);
            busqPrendas.RestaurarStock(cod, cant);
        }
    }
}
