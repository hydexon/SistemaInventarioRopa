namespace SistemaInventarioRopa_Desktop
{
    partial class PanelCompraVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabVentas = new MetroFramework.Controls.MetroTabPage();
            this.VentasGrid = new MetroFramework.Controls.MetroGrid();
            this.colCodVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmplResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompras = new MetroFramework.Controls.MetroTabPage();
            this.ComprasGrid = new MetroFramework.Controls.MetroGrid();
            this.colCodCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompraEmplResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasGrid)).BeginInit();
            this.tabCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 558);
            this.panel1.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabVentas);
            this.metroTabControl1.Controls.Add(this.tabCompras);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(737, 558);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.VentasGrid);
            this.tabVentas.HorizontalScrollbarBarColor = true;
            this.tabVentas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVentas.HorizontalScrollbarSize = 10;
            this.tabVentas.Location = new System.Drawing.Point(4, 44);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Size = new System.Drawing.Size(729, 510);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas (Salida Inventario)";
            this.tabVentas.VerticalScrollbarBarColor = true;
            this.tabVentas.VerticalScrollbarHighlightOnWheel = false;
            this.tabVentas.VerticalScrollbarSize = 10;
            // 
            // VentasGrid
            // 
            this.VentasGrid.AllowUserToAddRows = false;
            this.VentasGrid.AllowUserToDeleteRows = false;
            this.VentasGrid.AllowUserToResizeRows = false;
            this.VentasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VentasGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VentasGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VentasGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.VentasGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentasGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VentasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodVenta,
            this.colFechaVenta,
            this.colCliente,
            this.colEmplResponsable});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VentasGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.VentasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasGrid.EnableHeadersVisualStyles = false;
            this.VentasGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VentasGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VentasGrid.Location = new System.Drawing.Point(0, 0);
            this.VentasGrid.Name = "VentasGrid";
            this.VentasGrid.ReadOnly = true;
            this.VentasGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentasGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VentasGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.VentasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VentasGrid.Size = new System.Drawing.Size(729, 510);
            this.VentasGrid.Style = MetroFramework.MetroColorStyle.Magenta;
            this.VentasGrid.TabIndex = 2;
            // 
            // colCodVenta
            // 
            this.colCodVenta.HeaderText = "Cod.";
            this.colCodVenta.Name = "colCodVenta";
            this.colCodVenta.ReadOnly = true;
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.HeaderText = "Fecha Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colEmplResponsable
            // 
            this.colEmplResponsable.HeaderText = "Empleado Responsable";
            this.colEmplResponsable.Name = "colEmplResponsable";
            this.colEmplResponsable.ReadOnly = true;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.ComprasGrid);
            this.tabCompras.HorizontalScrollbarBarColor = true;
            this.tabCompras.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCompras.HorizontalScrollbarSize = 10;
            this.tabCompras.Location = new System.Drawing.Point(4, 44);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Size = new System.Drawing.Size(729, 510);
            this.tabCompras.TabIndex = 1;
            this.tabCompras.Text = "Compras (Entrada Inventario)";
            this.tabCompras.VerticalScrollbarBarColor = true;
            this.tabCompras.VerticalScrollbarHighlightOnWheel = false;
            this.tabCompras.VerticalScrollbarSize = 10;
            // 
            // ComprasGrid
            // 
            this.ComprasGrid.AllowUserToAddRows = false;
            this.ComprasGrid.AllowUserToDeleteRows = false;
            this.ComprasGrid.AllowUserToResizeRows = false;
            this.ComprasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComprasGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComprasGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComprasGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ComprasGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComprasGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ComprasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComprasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodCompra,
            this.colFechaCompra,
            this.colProveedor,
            this.colCompraEmplResponsable});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComprasGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.ComprasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGrid.EnableHeadersVisualStyles = false;
            this.ComprasGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ComprasGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComprasGrid.Location = new System.Drawing.Point(0, 0);
            this.ComprasGrid.Name = "ComprasGrid";
            this.ComprasGrid.ReadOnly = true;
            this.ComprasGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComprasGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ComprasGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ComprasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComprasGrid.Size = new System.Drawing.Size(729, 510);
            this.ComprasGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.ComprasGrid.TabIndex = 2;
            // 
            // colCodCompra
            // 
            this.colCodCompra.HeaderText = "Cod.";
            this.colCodCompra.Name = "colCodCompra";
            this.colCodCompra.ReadOnly = true;
            // 
            // colFechaCompra
            // 
            this.colFechaCompra.HeaderText = "Fecha Compra";
            this.colFechaCompra.Name = "colFechaCompra";
            this.colFechaCompra.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colCompraEmplResponsable
            // 
            this.colCompraEmplResponsable.HeaderText = "Empleado Responsable";
            this.colCompraEmplResponsable.Name = "colCompraEmplResponsable";
            this.colCompraEmplResponsable.ReadOnly = true;
            // 
            // PanelCompraVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanelCompraVentas";
            this.Size = new System.Drawing.Size(737, 558);
            this.Load += new System.EventHandler(this.PanelCompraVentas_Load);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VentasGrid)).EndInit();
            this.tabCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabVentas;
        private MetroFramework.Controls.MetroTabPage tabCompras;
        private MetroFramework.Controls.MetroGrid VentasGrid;
        private MetroFramework.Controls.MetroGrid ComprasGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmplResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompraEmplResponsable;
    }
}
