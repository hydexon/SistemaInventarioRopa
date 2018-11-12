namespace SistemaInventarioRopa_Desktop
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.OrbBtnRegistrarVenta = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.OrbBtnCerrarSesion = new System.Windows.Forms.RibbonOrbMenuItem();
            this.BtnSalir = new System.Windows.Forms.RibbonOrbMenuItem();
            this.btnQuickSell = new System.Windows.Forms.RibbonButton();
            this.btnQuickVenta = new System.Windows.Forms.RibbonButton();
            this.btnCerrarSesion = new System.Windows.Forms.RibbonButton();
            this.TabMercaderia = new System.Windows.Forms.RibbonTab();
            this.PanelInventario = new System.Windows.Forms.RibbonPanel();
            this.btnNuevaPrenda = new System.Windows.Forms.RibbonButton();
            this.BtnEditarPrenda = new System.Windows.Forms.RibbonButton();
            this.btnEliminarPrenda = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.btnNuevaCategoria = new System.Windows.Forms.RibbonButton();
            this.btnEliminarCategoria = new System.Windows.Forms.RibbonButton();
            this.PanelProveedores = new System.Windows.Forms.RibbonPanel();
            this.BtnEliminarProveedor = new System.Windows.Forms.RibbonButton();
            this.BtnModProv = new System.Windows.Forms.RibbonButton();
            this.BtnNuevoProveedor = new System.Windows.Forms.RibbonButton();
            this.VentasYComprasTab = new System.Windows.Forms.RibbonTab();
            this.VentasyComprasPanel = new System.Windows.Forms.RibbonPanel();
            this.BtnRegistrarCompra = new System.Windows.Forms.RibbonButton();
            this.btnRegistrarVenta = new System.Windows.Forms.RibbonButton();
            this.ConsultaRegistrosPanel = new System.Windows.Forms.RibbonPanel();
            this.btnMostrarCompra = new System.Windows.Forms.RibbonButton();
            this.ClientesTab = new System.Windows.Forms.RibbonTab();
            this.PanelClientesGestion = new System.Windows.Forms.RibbonPanel();
            this.btnNuevoCliente = new System.Windows.Forms.RibbonButton();
            this.BtnEditarCliente = new System.Windows.Forms.RibbonButton();
            this.BtnEliminarCliente = new System.Windows.Forms.RibbonButton();
            this.EmpleadosTab = new System.Windows.Forms.RibbonTab();
            this.PanelGestionEmpleados = new System.Windows.Forms.RibbonPanel();
            this.BtnNuevoEmpleado = new System.Windows.Forms.RibbonButton();
            this.btnEditarEmpleado = new System.Windows.Forms.RibbonButton();
            this.BtnEliminarEmpleado = new System.Windows.Forms.RibbonButton();
            this.ribbonDescriptionMenuItem1 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetallesVenta = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.OrbBtnRegistrarVenta);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.OrbBtnCerrarSesion);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.BtnSalir);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 207);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "Inicio";
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_16px;
            this.ribbon1.QuickAccessToolbar.Items.Add(this.btnQuickSell);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.btnQuickVenta);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.btnCerrarSesion);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(800, 150);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.TabMercaderia);
            this.ribbon1.Tabs.Add(this.VentasYComprasTab);
            this.ribbon1.Tabs.Add(this.ClientesTab);
            this.ribbon1.Tabs.Add(this.EmpleadosTab);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            this.ribbon1.TabSpacing = 4;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
            this.ribbon1.UseAlwaysStandardTheme = true;
            this.ribbon1.ActiveTabChanged += new System.EventHandler(this.ribbon1_ActiveTabChanged);
            // 
            // OrbBtnRegistrarVenta
            // 
            this.OrbBtnRegistrarVenta.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.OrbBtnRegistrarVenta.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_30px;
            this.OrbBtnRegistrarVenta.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_30px;
            this.OrbBtnRegistrarVenta.Name = "OrbBtnRegistrarVenta";
            this.OrbBtnRegistrarVenta.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_30px;
            this.OrbBtnRegistrarVenta.Text = "Registrar Venta";
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // OrbBtnCerrarSesion
            // 
            this.OrbBtnCerrarSesion.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.OrbBtnCerrarSesion.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_30px;
            this.OrbBtnCerrarSesion.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_30px;
            this.OrbBtnCerrarSesion.Name = "OrbBtnCerrarSesion";
            this.OrbBtnCerrarSesion.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_30px;
            this.OrbBtnCerrarSesion.Text = "Cerrar Sesión";
            this.OrbBtnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.BtnSalir.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_Sign_30px;
            this.BtnSalir.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_Sign_30px;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_Sign_30px;
            this.BtnSalir.Text = "Salir";
            // 
            // btnQuickSell
            // 
            this.btnQuickSell.Image = ((System.Drawing.Image)(resources.GetObject("btnQuickSell.Image")));
            this.btnQuickSell.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuickSell.LargeImage")));
            this.btnQuickSell.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.btnQuickSell.Name = "btnQuickSell";
            this.btnQuickSell.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_16px;
            this.btnQuickSell.Text = "Registrar Compra";
            this.btnQuickSell.ToolTip = "Registrar Compra";
            // 
            // btnQuickVenta
            // 
            this.btnQuickVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnQuickVenta.Image")));
            this.btnQuickVenta.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuickVenta.LargeImage")));
            this.btnQuickVenta.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.btnQuickVenta.Name = "btnQuickVenta";
            this.btnQuickVenta.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Shopping_Cart_16px;
            this.btnQuickVenta.Text = "Registrar Venta";
            this.btnQuickVenta.ToolTip = "Registrar Venta";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.LargeImage")));
            this.btnCerrarSesion.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Exit_16px;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.ToolTip = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // TabMercaderia
            // 
            this.TabMercaderia.Name = "TabMercaderia";
            this.TabMercaderia.Panels.Add(this.PanelInventario);
            this.TabMercaderia.Panels.Add(this.PanelProveedores);
            this.TabMercaderia.Text = "Mercadería";
            // 
            // PanelInventario
            // 
            this.PanelInventario.Items.Add(this.btnNuevaPrenda);
            this.PanelInventario.Items.Add(this.BtnEditarPrenda);
            this.PanelInventario.Items.Add(this.btnEliminarPrenda);
            this.PanelInventario.Items.Add(this.ribbonSeparator1);
            this.PanelInventario.Items.Add(this.btnNuevaCategoria);
            this.PanelInventario.Items.Add(this.btnEliminarCategoria);
            this.PanelInventario.Name = "PanelInventario";
            this.PanelInventario.Text = "Gestión de Inventario";
            // 
            // btnNuevaPrenda
            // 
            this.btnNuevaPrenda.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Plus_30px;
            this.btnNuevaPrenda.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Plus_30px;
            this.btnNuevaPrenda.Name = "btnNuevaPrenda";
            this.btnNuevaPrenda.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaPrenda.SmallImage")));
            this.btnNuevaPrenda.Text = "Nueva Prenda";
            this.btnNuevaPrenda.Click += new System.EventHandler(this.btnNuevaPrenda_Click);
            // 
            // BtnEditarPrenda
            // 
            this.BtnEditarPrenda.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Edit_30px;
            this.BtnEditarPrenda.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Edit_30px;
            this.BtnEditarPrenda.Name = "BtnEditarPrenda";
            this.BtnEditarPrenda.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEditarPrenda.SmallImage")));
            this.BtnEditarPrenda.Text = "Modificar Prenda";
            this.BtnEditarPrenda.Click += new System.EventHandler(this.BtnEditarPrenda_Click);
            // 
            // btnEliminarPrenda
            // 
            this.btnEliminarPrenda.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Trash_Can_30px;
            this.btnEliminarPrenda.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Trash_Can_30px;
            this.btnEliminarPrenda.Name = "btnEliminarPrenda";
            this.btnEliminarPrenda.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPrenda.SmallImage")));
            this.btnEliminarPrenda.Text = "Eliminar Prenda";
            this.btnEliminarPrenda.Click += new System.EventHandler(this.btnEliminarPrenda_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaCategoria.Image")));
            this.btnNuevaCategoria.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaCategoria.LargeImage")));
            this.btnNuevaCategoria.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Add_Tag_16px;
            this.btnNuevaCategoria.Text = "Nueva Categoria";
            this.btnNuevaCategoria.Click += new System.EventHandler(this.btnNuevaCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Remove_Tag_16px;
            this.btnEliminarCategoria.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Remove_Tag_16px;
            this.btnEliminarCategoria.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.SmallImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Remove_Tag_16px;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // PanelProveedores
            // 
            this.PanelProveedores.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Left;
            this.PanelProveedores.Items.Add(this.BtnEliminarProveedor);
            this.PanelProveedores.Items.Add(this.BtnModProv);
            this.PanelProveedores.Items.Add(this.BtnNuevoProveedor);
            this.PanelProveedores.Name = "PanelProveedores";
            this.PanelProveedores.Text = "Proveedores";
            // 
            // BtnEliminarProveedor
            // 
            this.BtnEliminarProveedor.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Delete_30px;
            this.BtnEliminarProveedor.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Delete_30px;
            this.BtnEliminarProveedor.Name = "BtnEliminarProveedor";
            this.BtnEliminarProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarProveedor.SmallImage")));
            this.BtnEliminarProveedor.Text = "Eliminar Proveedor";
            this.BtnEliminarProveedor.Click += new System.EventHandler(this.BtnEliminarProveedor_Click);
            // 
            // BtnModProv
            // 
            this.BtnModProv.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Edit_30px;
            this.BtnModProv.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Edit_30px;
            this.BtnModProv.Name = "BtnModProv";
            this.BtnModProv.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnModProv.SmallImage")));
            this.BtnModProv.Text = "Editar Proveedor";
            this.BtnModProv.Click += new System.EventHandler(this.BtnModProv_Click);
            // 
            // BtnNuevoProveedor
            // 
            this.BtnNuevoProveedor.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Add_User_Male_30px;
            this.BtnNuevoProveedor.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Add_User_Male_30px;
            this.BtnNuevoProveedor.Name = "BtnNuevoProveedor";
            this.BtnNuevoProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoProveedor.SmallImage")));
            this.BtnNuevoProveedor.Text = "Nuevo Proveedor";
            this.BtnNuevoProveedor.Click += new System.EventHandler(this.BtnNuevoProveedor_Click);
            // 
            // VentasYComprasTab
            // 
            this.VentasYComprasTab.Name = "VentasYComprasTab";
            this.VentasYComprasTab.Panels.Add(this.VentasyComprasPanel);
            this.VentasYComprasTab.Panels.Add(this.ConsultaRegistrosPanel);
            this.VentasYComprasTab.Text = "Ventas y Compras";
            // 
            // VentasyComprasPanel
            // 
            this.VentasyComprasPanel.Items.Add(this.BtnRegistrarCompra);
            this.VentasyComprasPanel.Items.Add(this.btnRegistrarVenta);
            this.VentasyComprasPanel.Name = "VentasyComprasPanel";
            this.VentasyComprasPanel.Text = "Ventas y Compras";
            // 
            // BtnRegistrarCompra
            // 
            this.BtnRegistrarCompra.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_30px;
            this.BtnRegistrarCompra.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Sell_30px;
            this.BtnRegistrarCompra.Name = "BtnRegistrarCompra";
            this.BtnRegistrarCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarCompra.SmallImage")));
            this.BtnRegistrarCompra.Text = "Registrar Compra";
            this.BtnRegistrarCompra.Click += new System.EventHandler(this.BtnRegistrarCompra_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Shopping_Cart_30px;
            this.btnRegistrarVenta.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Shopping_Cart_30px;
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVenta.SmallImage")));
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // ConsultaRegistrosPanel
            // 
            this.ConsultaRegistrosPanel.Items.Add(this.btnMostrarCompra);
            this.ConsultaRegistrosPanel.Items.Add(this.btnDetallesVenta);
            this.ConsultaRegistrosPanel.Name = "ConsultaRegistrosPanel";
            this.ConsultaRegistrosPanel.Text = "Consultar Registros";
            // 
            // btnMostrarCompra
            // 
            this.btnMostrarCompra.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.receipt_invoice;
            this.btnMostrarCompra.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.receipt_invoice;
            this.btnMostrarCompra.Name = "btnMostrarCompra";
            this.btnMostrarCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarCompra.SmallImage")));
            this.btnMostrarCompra.Text = "Detalles Compra";
            this.btnMostrarCompra.Click += new System.EventHandler(this.btnMostrarCompra_Click);
            // 
            // ClientesTab
            // 
            this.ClientesTab.Name = "ClientesTab";
            this.ClientesTab.Panels.Add(this.PanelClientesGestion);
            this.ClientesTab.Text = "Clientes";
            // 
            // PanelClientesGestion
            // 
            this.PanelClientesGestion.Items.Add(this.btnNuevoCliente);
            this.PanelClientesGestion.Items.Add(this.BtnEditarCliente);
            this.PanelClientesGestion.Items.Add(this.BtnEliminarCliente);
            this.PanelClientesGestion.Name = "PanelClientesGestion";
            this.PanelClientesGestion.Text = "Gestión de Clientes";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Reception_30px;
            this.btnNuevoCliente.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Reception_30px;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.SmallImage")));
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // BtnEditarCliente
            // 
            this.BtnEditarCliente.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Edit_Property_30px;
            this.BtnEditarCliente.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Edit_Property_30px;
            this.BtnEditarCliente.Name = "BtnEditarCliente";
            this.BtnEditarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEditarCliente.SmallImage")));
            this.BtnEditarCliente.Text = "Editar Cliente";
            this.BtnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // BtnEliminarCliente
            // 
            this.BtnEliminarCliente.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Trash_Can_30px;
            this.BtnEliminarCliente.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Trash_Can_30px;
            this.BtnEliminarCliente.Name = "BtnEliminarCliente";
            this.BtnEliminarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCliente.SmallImage")));
            this.BtnEliminarCliente.Text = "Eliminar Cliente";
            this.BtnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
            // 
            // EmpleadosTab
            // 
            this.EmpleadosTab.Name = "EmpleadosTab";
            this.EmpleadosTab.Panels.Add(this.PanelGestionEmpleados);
            this.EmpleadosTab.Text = "Empleados";
            // 
            // PanelGestionEmpleados
            // 
            this.PanelGestionEmpleados.Items.Add(this.BtnNuevoEmpleado);
            this.PanelGestionEmpleados.Items.Add(this.btnEditarEmpleado);
            this.PanelGestionEmpleados.Items.Add(this.BtnEliminarEmpleado);
            this.PanelGestionEmpleados.Name = "PanelGestionEmpleados";
            this.PanelGestionEmpleados.Text = "Gestión de Empleados";
            // 
            // BtnNuevoEmpleado
            // 
            this.BtnNuevoEmpleado.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Add_User_Group_Woman_Man_30px;
            this.BtnNuevoEmpleado.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Add_User_Group_Woman_Man_30px;
            this.BtnNuevoEmpleado.Name = "BtnNuevoEmpleado";
            this.BtnNuevoEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoEmpleado.SmallImage")));
            this.BtnNuevoEmpleado.Text = "Nuevo Empleado";
            this.BtnNuevoEmpleado.Click += new System.EventHandler(this.BtnNuevoEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Compose_40px;
            this.btnEditarEmpleado.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Compose_40px;
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEditarEmpleado.SmallImage")));
            this.btnEditarEmpleado.Text = "Editar Empleado";
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Erase_40px;
            this.BtnEliminarEmpleado.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.Erase_40px;
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarEmpleado.SmallImage")));
            this.BtnEliminarEmpleado.Text = "Borrar Empleado";
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // ribbonDescriptionMenuItem1
            // 
            this.ribbonDescriptionMenuItem1.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.Image")));
            this.ribbonDescriptionMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.LargeImage")));
            this.ribbonDescriptionMenuItem1.Name = "ribbonDescriptionMenuItem1";
            this.ribbonDescriptionMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.SmallImage")));
            this.ribbonDescriptionMenuItem1.Text = "ribbonDescriptionMenuItem1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 452);
            this.panel1.TabIndex = 1;
            // 
            // btnDetallesVenta
            // 
            this.btnDetallesVenta.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.receipt_invoice;
            this.btnDetallesVenta.LargeImage = global::SistemaInventarioRopa_Desktop.Properties.Resources.receipt_invoice;
            this.btnDetallesVenta.Name = "btnDetallesVenta";
            this.btnDetallesVenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDetallesVenta.SmallImage")));
            this.btnDetallesVenta.Text = "Detalles Venta";
            this.btnDetallesVenta.Click += new System.EventHandler(this.btnDetallesVenta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Inventario de Ropa";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab TabMercaderia;
        private System.Windows.Forms.RibbonPanel PanelInventario;
        private System.Windows.Forms.RibbonTab VentasYComprasTab;
        private System.Windows.Forms.RibbonButton btnNuevaPrenda;
        private System.Windows.Forms.RibbonButton BtnEditarPrenda;
        private System.Windows.Forms.RibbonButton btnEliminarPrenda;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton btnNuevaCategoria;
        private System.Windows.Forms.RibbonButton btnEliminarCategoria;
        private System.Windows.Forms.RibbonPanel PanelProveedores;
        private System.Windows.Forms.RibbonButton BtnEliminarProveedor;
        private System.Windows.Forms.RibbonButton BtnModProv;
        private System.Windows.Forms.RibbonButton BtnNuevoProveedor;
        private System.Windows.Forms.RibbonTab ClientesTab;
        private System.Windows.Forms.RibbonPanel VentasyComprasPanel;
        private System.Windows.Forms.RibbonButton BtnRegistrarCompra;
        private System.Windows.Forms.RibbonButton btnRegistrarVenta;
        private System.Windows.Forms.RibbonTab EmpleadosTab;
        private System.Windows.Forms.RibbonOrbMenuItem OrbBtnRegistrarVenta;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonOrbMenuItem OrbBtnCerrarSesion;
        private System.Windows.Forms.RibbonOrbMenuItem BtnSalir;
        private System.Windows.Forms.RibbonPanel PanelClientesGestion;
        private System.Windows.Forms.RibbonPanel PanelBusqueda;
        private System.Windows.Forms.RibbonButton btnNuevoCliente;
        private System.Windows.Forms.RibbonButton BtnEditarCliente;
        private System.Windows.Forms.RibbonButton BtnEliminarCliente;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem1;
        private System.Windows.Forms.RibbonPanel PanelGestionEmpleados;
        private System.Windows.Forms.RibbonPanel PanelBusquedaCliente;
        private System.Windows.Forms.RibbonButton BtnNuevoEmpleado;
        private System.Windows.Forms.RibbonButton btnEditarEmpleado;
        private System.Windows.Forms.RibbonButton BtnEliminarEmpleado;
        private System.Windows.Forms.RibbonPanel PanelBusquedaEmpleado;
        private System.Windows.Forms.RibbonButton btnQuickSell;
        private System.Windows.Forms.RibbonButton btnQuickVenta;
        private System.Windows.Forms.RibbonButton btnCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RibbonPanel ConsultaRegistrosPanel;
        private System.Windows.Forms.RibbonButton btnMostrarCompra;
        private System.Windows.Forms.RibbonButton btnDetallesVenta;
    }
}

