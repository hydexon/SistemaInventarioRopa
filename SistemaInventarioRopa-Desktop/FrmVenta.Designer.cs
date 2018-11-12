namespace SistemaInventarioRopa_Desktop
{
    partial class FrmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNo = new MetroFramework.Controls.MetroLabel();
            this.txtCodVenta = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cbCliente = new MetroFramework.Controls.MetroComboBox();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.txtDUI = new MetroFramework.Controls.MetroTextBox();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblDUI = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblTituloCliente = new MetroFramework.Controls.MetroLabel();
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.lblEgreso = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.lblSubtotal = new MetroFramework.Controls.MetroLabel();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIva = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.lblEmpleado = new MetroFramework.Controls.MetroLabel();
            this.txtEmpleadoResponsable = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNo.Location = new System.Drawing.Point(23, 69);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(32, 25);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "N°";
            // 
            // txtCodVenta
            // 
            // 
            // 
            // 
            this.txtCodVenta.CustomButton.Image = null;
            this.txtCodVenta.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtCodVenta.CustomButton.Name = "";
            this.txtCodVenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodVenta.CustomButton.TabIndex = 1;
            this.txtCodVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodVenta.CustomButton.UseSelectable = true;
            this.txtCodVenta.CustomButton.Visible = false;
            this.txtCodVenta.Lines = new string[0];
            this.txtCodVenta.Location = new System.Drawing.Point(61, 69);
            this.txtCodVenta.MaxLength = 32767;
            this.txtCodVenta.Name = "txtCodVenta";
            this.txtCodVenta.PasswordChar = '\0';
            this.txtCodVenta.ReadOnly = true;
            this.txtCodVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodVenta.SelectedText = "";
            this.txtCodVenta.SelectionLength = 0;
            this.txtCodVenta.SelectionStart = 0;
            this.txtCodVenta.ShortcutsEnabled = true;
            this.txtCodVenta.Size = new System.Drawing.Size(150, 23);
            this.txtCodVenta.TabIndex = 1;
            this.txtCodVenta.UseSelectable = true;
            this.txtCodVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.cbCliente);
            this.metroPanel1.Controls.Add(this.txtDireccion);
            this.metroPanel1.Controls.Add(this.txtDUI);
            this.metroPanel1.Controls.Add(this.lblDireccion);
            this.metroPanel1.Controls.Add(this.lblDUI);
            this.metroPanel1.Controls.Add(this.lblNombre);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 133);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(490, 91);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.ItemHeight = 23;
            this.cbCliente.Location = new System.Drawing.Point(86, 3);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(390, 29);
            this.cbCliente.TabIndex = 8;
            this.cbCliente.UseSelectable = true;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(368, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(86, 62);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(390, 23);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDUI
            // 
            // 
            // 
            // 
            this.txtDUI.CustomButton.Image = null;
            this.txtDUI.CustomButton.Location = new System.Drawing.Point(368, 1);
            this.txtDUI.CustomButton.Name = "";
            this.txtDUI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDUI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDUI.CustomButton.TabIndex = 1;
            this.txtDUI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDUI.CustomButton.UseSelectable = true;
            this.txtDUI.CustomButton.Visible = false;
            this.txtDUI.Lines = new string[0];
            this.txtDUI.Location = new System.Drawing.Point(86, 36);
            this.txtDUI.MaxLength = 32767;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.PasswordChar = '\0';
            this.txtDUI.ReadOnly = true;
            this.txtDUI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDUI.SelectedText = "";
            this.txtDUI.SelectionLength = 0;
            this.txtDUI.SelectionStart = 0;
            this.txtDUI.ShortcutsEnabled = true;
            this.txtDUI.Size = new System.Drawing.Size(390, 23);
            this.txtDUI.TabIndex = 6;
            this.txtDUI.UseSelectable = true;
            this.txtDUI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDUI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(14, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 19);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(47, 36);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(33, 19);
            this.lblDUI.TabIndex = 3;
            this.lblDUI.Text = "DUI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Location = new System.Drawing.Point(23, 111);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(52, 19);
            this.lblTituloCliente.TabIndex = 3;
            this.lblTituloCliente.Text = "Cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFecha.Location = new System.Drawing.Point(217, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 25);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(283, 65);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(230, 29);
            this.metroDateTime1.TabIndex = 7;
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(24, 231);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(52, 19);
            this.lblEgreso.TabIndex = 8;
            this.lblEgreso.Text = "Egreso:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroGrid1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(24, 253);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(489, 211);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colProducto,
            this.colMarca,
            this.colTalla,
            this.colPU,
            this.colCantidad});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(489, 211);
            this.metroGrid1.TabIndex = 2;
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod.";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
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
            // colPU
            // 
            this.colPU.HeaderText = "Precio Unitario";
            this.colPU.Name = "colPU";
            this.colPU.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(407, 568);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseSelectable = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(295, 568);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(283, 470);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(79, 19);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal ($):";
            // 
            // txtSubtotal
            // 
            // 
            // 
            // 
            this.txtSubtotal.CustomButton.Image = null;
            this.txtSubtotal.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtSubtotal.CustomButton.Name = "";
            this.txtSubtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtotal.CustomButton.TabIndex = 1;
            this.txtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtotal.CustomButton.UseSelectable = true;
            this.txtSubtotal.CustomButton.Visible = false;
            this.txtSubtotal.Lines = new string[0];
            this.txtSubtotal.Location = new System.Drawing.Point(376, 470);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(137, 23);
            this.txtSubtotal.TabIndex = 13;
            this.txtSubtotal.UseSelectable = true;
            this.txtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(296, 500);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "IVA (13%):";
            // 
            // txtIva
            // 
            // 
            // 
            // 
            this.txtIva.CustomButton.Image = null;
            this.txtIva.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtIva.CustomButton.Name = "";
            this.txtIva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIva.CustomButton.TabIndex = 1;
            this.txtIva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIva.CustomButton.UseSelectable = true;
            this.txtIva.CustomButton.Visible = false;
            this.txtIva.Lines = new string[0];
            this.txtIva.Location = new System.Drawing.Point(376, 500);
            this.txtIva.MaxLength = 32767;
            this.txtIva.Name = "txtIva";
            this.txtIva.PasswordChar = '\0';
            this.txtIva.ReadOnly = true;
            this.txtIva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIva.SelectedText = "";
            this.txtIva.SelectionLength = 0;
            this.txtIva.SelectionStart = 0;
            this.txtIva.ShortcutsEnabled = true;
            this.txtIva.Size = new System.Drawing.Size(137, 23);
            this.txtIva.TabIndex = 15;
            this.txtIva.UseSelectable = true;
            this.txtIva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(304, 529);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Total ($):";
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(376, 529);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 23);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(21, 487);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(149, 19);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado Responsable:";
            // 
            // txtEmpleadoResponsable
            // 
            // 
            // 
            // 
            this.txtEmpleadoResponsable.CustomButton.Image = null;
            this.txtEmpleadoResponsable.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtEmpleadoResponsable.CustomButton.Name = "";
            this.txtEmpleadoResponsable.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpleadoResponsable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpleadoResponsable.CustomButton.TabIndex = 1;
            this.txtEmpleadoResponsable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpleadoResponsable.CustomButton.UseSelectable = true;
            this.txtEmpleadoResponsable.CustomButton.Visible = false;
            this.txtEmpleadoResponsable.Lines = new string[0];
            this.txtEmpleadoResponsable.Location = new System.Drawing.Point(24, 509);
            this.txtEmpleadoResponsable.MaxLength = 32767;
            this.txtEmpleadoResponsable.Name = "txtEmpleadoResponsable";
            this.txtEmpleadoResponsable.PasswordChar = '\0';
            this.txtEmpleadoResponsable.ReadOnly = true;
            this.txtEmpleadoResponsable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpleadoResponsable.SelectedText = "";
            this.txtEmpleadoResponsable.SelectionLength = 0;
            this.txtEmpleadoResponsable.SelectionStart = 0;
            this.txtEmpleadoResponsable.ShortcutsEnabled = true;
            this.txtEmpleadoResponsable.Size = new System.Drawing.Size(230, 23);
            this.txtEmpleadoResponsable.TabIndex = 21;
            this.txtEmpleadoResponsable.UseSelectable = true;
            this.txtEmpleadoResponsable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpleadoResponsable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Add_New_16px;
            this.btnAgregar.Location = new System.Drawing.Point(439, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(34, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::SistemaInventarioRopa_Desktop.Properties.Resources.Minus_16px;
            this.btnEliminar.Location = new System.Drawing.Point(479, 227);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(34, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 614);
            this.Controls.Add(this.txtEmpleadoResponsable);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloCliente);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txtCodVenta);
            this.Controls.Add(this.lblNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVenta";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro Venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenta_FormClosed);
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNo;
        private MetroFramework.Controls.MetroTextBox txtCodVenta;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblTituloCliente;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroLabel lblDUI;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroTextBox txtDUI;
        private MetroFramework.Controls.MetroLabel lblFecha;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel lblEgreso;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnRegistrar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroLabel lblSubtotal;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIva;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel lblEmpleado;
        private MetroFramework.Controls.MetroTextBox txtEmpleadoResponsable;
        private MetroFramework.Controls.MetroComboBox cbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    }
}