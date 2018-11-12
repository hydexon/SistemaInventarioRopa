namespace SistemaInventarioRopa_Desktop
{
    partial class PanelMercaderia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabProveedores = new MetroFramework.Controls.MetroTabPage();
            this.ProveedoresGrid = new MetroFramework.Controls.MetroGrid();
            this.colCodProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventarioTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.InventarioPrendasGrid = new MetroFramework.Controls.MetroGrid();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresGrid)).BeginInit();
            this.InventarioTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioPrendasGrid)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabProveedores
            // 
            this.TabProveedores.Controls.Add(this.ProveedoresGrid);
            this.TabProveedores.HorizontalScrollbarBarColor = true;
            this.TabProveedores.HorizontalScrollbarHighlightOnWheel = false;
            this.TabProveedores.HorizontalScrollbarSize = 10;
            this.TabProveedores.Location = new System.Drawing.Point(4, 44);
            this.TabProveedores.Name = "TabProveedores";
            this.TabProveedores.Size = new System.Drawing.Size(706, 417);
            this.TabProveedores.TabIndex = 1;
            this.TabProveedores.Text = "Proveedores";
            this.TabProveedores.VerticalScrollbarBarColor = true;
            this.TabProveedores.VerticalScrollbarHighlightOnWheel = false;
            this.TabProveedores.VerticalScrollbarSize = 10;
            // 
            // ProveedoresGrid
            // 
            this.ProveedoresGrid.AllowUserToAddRows = false;
            this.ProveedoresGrid.AllowUserToDeleteRows = false;
            this.ProveedoresGrid.AllowUserToResizeRows = false;
            this.ProveedoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProveedoresGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProveedoresGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProveedoresGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProveedoresGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProveedoresGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProveedoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodProveedor,
            this.colNombreProveedor,
            this.colDireccion,
            this.colTelefono,
            this.colEmail,
            this.colRepresentante});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProveedoresGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProveedoresGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedoresGrid.EnableHeadersVisualStyles = false;
            this.ProveedoresGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProveedoresGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProveedoresGrid.Location = new System.Drawing.Point(0, 0);
            this.ProveedoresGrid.Name = "ProveedoresGrid";
            this.ProveedoresGrid.ReadOnly = true;
            this.ProveedoresGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProveedoresGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProveedoresGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProveedoresGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresGrid.Size = new System.Drawing.Size(706, 417);
            this.ProveedoresGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.ProveedoresGrid.TabIndex = 2;
            // 
            // colCodProveedor
            // 
            this.colCodProveedor.HeaderText = "Cod.";
            this.colCodProveedor.Name = "colCodProveedor";
            this.colCodProveedor.ReadOnly = true;
            // 
            // colNombreProveedor
            // 
            this.colNombreProveedor.HeaderText = "Nombre Proveedor";
            this.colNombreProveedor.Name = "colNombreProveedor";
            this.colNombreProveedor.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colRepresentante
            // 
            this.colRepresentante.HeaderText = "Representante";
            this.colRepresentante.Name = "colRepresentante";
            this.colRepresentante.ReadOnly = true;
            // 
            // InventarioTab
            // 
            this.InventarioTab.Controls.Add(this.metroPanel1);
            this.InventarioTab.HorizontalScrollbarBarColor = true;
            this.InventarioTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InventarioTab.HorizontalScrollbarSize = 10;
            this.InventarioTab.Location = new System.Drawing.Point(4, 44);
            this.InventarioTab.Name = "InventarioTab";
            this.InventarioTab.Size = new System.Drawing.Size(706, 417);
            this.InventarioTab.TabIndex = 0;
            this.InventarioTab.Text = "Inventario Prendas";
            this.InventarioTab.VerticalScrollbarBarColor = true;
            this.InventarioTab.VerticalScrollbarHighlightOnWheel = false;
            this.InventarioTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.InventarioPrendasGrid);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(706, 417);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // InventarioPrendasGrid
            // 
            this.InventarioPrendasGrid.AllowUserToAddRows = false;
            this.InventarioPrendasGrid.AllowUserToDeleteRows = false;
            this.InventarioPrendasGrid.AllowUserToResizeRows = false;
            this.InventarioPrendasGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventarioPrendasGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventarioPrendasGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventarioPrendasGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventarioPrendasGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InventarioPrendasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventarioPrendasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colImagen,
            this.colNombre,
            this.colMarca,
            this.colTalla,
            this.colStock,
            this.colPrecioVenta,
            this.colPrecioCompra,
            this.colProveedor,
            this.colCategoria});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventarioPrendasGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.InventarioPrendasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventarioPrendasGrid.EnableHeadersVisualStyles = false;
            this.InventarioPrendasGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InventarioPrendasGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventarioPrendasGrid.Location = new System.Drawing.Point(0, 0);
            this.InventarioPrendasGrid.Name = "InventarioPrendasGrid";
            this.InventarioPrendasGrid.ReadOnly = true;
            this.InventarioPrendasGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventarioPrendasGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.InventarioPrendasGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventarioPrendasGrid.RowTemplate.Height = 48;
            this.InventarioPrendasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventarioPrendasGrid.Size = new System.Drawing.Size(706, 417);
            this.InventarioPrendasGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.InventarioPrendasGrid.TabIndex = 2;
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod.";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            // 
            // colImagen
            // 
            this.colImagen.HeaderText = "Imagen";
            this.colImagen.Name = "colImagen";
            this.colImagen.ReadOnly = true;
            this.colImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colTalla
            // 
            this.colTalla.HeaderText = "Talla";
            this.colTalla.Name = "colTalla";
            this.colTalla.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.HeaderText = "Precio Venta ($)";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.HeaderText = "Precio Compra ($)";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.InventarioTab);
            this.metroTabControl1.Controls.Add(this.TabProveedores);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(714, 465);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // PanelMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "PanelMercaderia";
            this.Size = new System.Drawing.Size(714, 465);
            this.Load += new System.EventHandler(this.PanelMercaderia_Load);
            this.TabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresGrid)).EndInit();
            this.InventarioTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventarioPrendasGrid)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage TabProveedores;
        private MetroFramework.Controls.MetroTabPage InventarioTab;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid InventarioPrendasGrid;
        private MetroFramework.Controls.MetroGrid ProveedoresGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepresentante;
    }
}
