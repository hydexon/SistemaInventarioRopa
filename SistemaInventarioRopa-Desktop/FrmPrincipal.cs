using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SistemaInventarioRopa_Desktop
{
    public partial class FrmPrincipal : RibbonForm
    {
        private PanelMercaderia pnlMercaderia;
        private PanelCompraVentas pnlCompraVentas;
        private PanelClientes pnlClientes;
        private PanelEmpleados pnlEmpleados;

        private UserControl panelActual = null;

        private GestionInventario inventario;

        public FrmPrincipal()
        {
            InitializeComponent();

            inventario = new GestionInventario();
            pnlMercaderia = new PanelMercaderia();
            pnlCompraVentas = new PanelCompraVentas();
            pnlClientes = new PanelClientes();
            pnlEmpleados = new PanelEmpleados();
            //-----------------------------------
            pnlMercaderia.Visible = false;
            pnlClientes.Visible = false;
            pnlCompraVentas.Visible = false;
            pnlEmpleados.Visible = false;
            //-----------------------------------
            pnlMercaderia.Dock = DockStyle.Fill;
            pnlClientes.Dock = DockStyle.Fill;
            pnlCompraVentas.Dock = DockStyle.Fill;
            pnlEmpleados.Dock = DockStyle.Fill;

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {  
            panel1.Controls.AddRange(new Control[]{ pnlMercaderia, pnlCompraVentas, pnlClientes, pnlEmpleados});
            Hide();
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() != DialogResult.OK)
                Application.Exit();
            else
                Show();

            //Colocar al panel de mercaderia por defecto:
            pnlMercaderia.Visible = true;
            panelActual = pnlMercaderia;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();

            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() != DialogResult.OK)
                Application.Exit();
            else
                Show();
        }

        private void btnNuevaPrenda_Click(object sender, EventArgs e)
        {
            pnlMercaderia.NuevaPrenda();
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            pnlCompraVentas.RegistrarCompra();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            pnlCompraVentas.RegistrarVenta();
        }

        private void ribbon1_ActiveTabChanged(object sender, EventArgs e)
        {
            panelActual.Visible = false;
            switch (ribbon1.Tabs.IndexOf(ribbon1.ActiveTab))
            {
                case 0:
                    pnlMercaderia.Visible = true;
                    panelActual = pnlMercaderia;
                    break;
                case 1:
                    pnlCompraVentas.Visible = true;
                    panelActual = pnlCompraVentas;
                    break;
                case 2:
                    pnlClientes.Visible = true;
                    panelActual = pnlClientes;
                    break;
                case 3:
                    if (GestionUsuarios.Instancia.UsuarioActualEsAdmin)
                    {
                        pnlEmpleados.Visible = true;
                        panelActual = pnlEmpleados;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Lo sentimos!, usted no es un usuario administrador y no podemos mostrar esta vista.");
                        ribbon1.ActivatePreviousTab();
                    }
                    break;
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            FrmNuevaCategoria nuevaCategoria = new FrmNuevaCategoria(ref inventario);
            nuevaCategoria.ShowDialog();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            FrmBorrarCategoria borrarCategoria = new FrmBorrarCategoria(ref inventario);
            borrarCategoria.ShowDialog();
        }

        private void BtnEditarPrenda_Click(object sender, EventArgs e)
        {
            pnlMercaderia.ModificarPrenda();
        }

        private void btnEliminarPrenda_Click(object sender, EventArgs e)
        {
            pnlMercaderia.EliminarPrenda();
        }

        private void BtnNuevoProveedor_Click(object sender, EventArgs e)
        {
            pnlMercaderia.NuevoProveedor();
        }

        private void BtnModProv_Click(object sender, EventArgs e)
        {
            pnlMercaderia.EditarProveedor();
        }

        private void BtnEliminarProveedor_Click(object sender, EventArgs e)
        {
            pnlMercaderia.EliminarProveedor();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            pnlClientes.NuevoCliente();
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            pnlClientes.EliminarCliente();
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            pnlClientes.ModificarCliente();
        }

        private void BtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            pnlEmpleados.NuevoEmpleado();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            pnlEmpleados.ModificarEmpleado();
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            pnlEmpleados.EliminarEmpleado();
        }

        private void btnMostrarCompra_Click(object sender, EventArgs e)
        {
            pnlCompraVentas.DetallesCompra();
        }

        private void btnDetallesVenta_Click(object sender, EventArgs e)
        {
            pnlCompraVentas.DetallesVenta();
        }
    }
}
