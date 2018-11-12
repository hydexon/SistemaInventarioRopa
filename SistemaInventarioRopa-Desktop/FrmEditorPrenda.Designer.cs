namespace SistemaInventarioRopa_Desktop
{
    partial class FrmEditorPrenda
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
            this.btnSelImagen = new MetroFramework.Controls.MetroButton();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.txtNombreProd = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.lblProveedor = new MetroFramework.Controls.MetroLabel();
            this.cbProveedor = new MetroFramework.Controls.MetroComboBox();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblTalla = new MetroFramework.Controls.MetroLabel();
            this.cbTalla = new MetroFramework.Controls.MetroComboBox();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.cbCategoria = new MetroFramework.Controls.MetroComboBox();
            this.lblPrecioVenta = new MetroFramework.Controls.MetroLabel();
            this.numPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardarCambios = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelImagen
            // 
            this.btnSelImagen.Location = new System.Drawing.Point(23, 200);
            this.btnSelImagen.Name = "btnSelImagen";
            this.btnSelImagen.Size = new System.Drawing.Size(127, 23);
            this.btnSelImagen.TabIndex = 1;
            this.btnSelImagen.Text = "Seleccionar Imagen";
            this.btnSelImagen.UseSelectable = true;
            this.btnSelImagen.Click += new System.EventHandler(this.btnSelImagen_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(165, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Producto:";
            // 
            // txtNombreProd
            // 
            // 
            // 
            // 
            this.txtNombreProd.CustomButton.Image = null;
            this.txtNombreProd.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txtNombreProd.CustomButton.Name = "";
            this.txtNombreProd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProd.CustomButton.TabIndex = 1;
            this.txtNombreProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProd.CustomButton.UseSelectable = true;
            this.txtNombreProd.CustomButton.Visible = false;
            this.txtNombreProd.Lines = new string[] {
        "metroTextBox1"};
            this.txtNombreProd.Location = new System.Drawing.Point(240, 63);
            this.txtNombreProd.MaxLength = 32767;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.PasswordChar = '\0';
            this.txtNombreProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProd.SelectedText = "";
            this.txtNombreProd.SelectionLength = 0;
            this.txtNombreProd.SelectionStart = 0;
            this.txtNombreProd.ShortcutsEnabled = true;
            this.txtNombreProd.Size = new System.Drawing.Size(271, 23);
            this.txtNombreProd.TabIndex = 3;
            this.txtNombreProd.Text = "metroTextBox1";
            this.txtNombreProd.UseSelectable = true;
            this.txtNombreProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(182, 93);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            // 
            // 
            // 
            this.txtMarca.CustomButton.Image = null;
            this.txtMarca.CustomButton.Location = new System.Drawing.Point(249, 1);
            this.txtMarca.CustomButton.Name = "";
            this.txtMarca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarca.CustomButton.TabIndex = 1;
            this.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarca.CustomButton.UseSelectable = true;
            this.txtMarca.CustomButton.Visible = false;
            this.txtMarca.Lines = new string[] {
        "metroTextBox2"};
            this.txtMarca.Location = new System.Drawing.Point(240, 93);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(271, 23);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.Text = "metroTextBox2";
            this.txtMarca.UseSelectable = true;
            this.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(156, 122);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(75, 19);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.ItemHeight = 23;
            this.cbProveedor.Location = new System.Drawing.Point(240, 122);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(271, 29);
            this.cbProveedor.TabIndex = 7;
            this.cbProveedor.UseSelectable = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(188, 157);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 19);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(240, 157);
            this.numStock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(271, 20);
            this.numStock.TabIndex = 9;
            this.numStock.ThousandsSeparator = true;
            this.numStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(194, 183);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(37, 19);
            this.lblTalla.TabIndex = 10;
            this.lblTalla.Text = "Talla:";
            // 
            // cbTalla
            // 
            this.cbTalla.FormattingEnabled = true;
            this.cbTalla.ItemHeight = 23;
            this.cbTalla.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cbTalla.Location = new System.Drawing.Point(240, 183);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(271, 29);
            this.cbTalla.TabIndex = 11;
            this.cbTalla.UseSelectable = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(164, 218);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 19);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.ItemHeight = 23;
            this.cbCategoria.Location = new System.Drawing.Point(240, 218);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(271, 29);
            this.cbCategoria.TabIndex = 13;
            this.cbCategoria.UseSelectable = true;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(127, 254);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(104, 19);
            this.lblPrecioVenta.TabIndex = 14;
            this.lblPrecioVenta.Text = "Precio Venta ($):";
            // 
            // numPrecioVenta
            // 
            this.numPrecioVenta.DecimalPlaces = 2;
            this.numPrecioVenta.Location = new System.Drawing.Point(237, 254);
            this.numPrecioVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecioVenta.Name = "numPrecioVenta";
            this.numPrecioVenta.Size = new System.Drawing.Size(274, 20);
            this.numPrecioVenta.TabIndex = 15;
            this.numPrecioVenta.ThousandsSeparator = true;
            this.numPrecioVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPrecioCompra
            // 
            this.numPrecioCompra.DecimalPlaces = 2;
            this.numPrecioCompra.Location = new System.Drawing.Point(237, 280);
            this.numPrecioCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecioCompra.Name = "numPrecioCompra";
            this.numPrecioCompra.Size = new System.Drawing.Size(274, 20);
            this.numPrecioCompra.TabIndex = 17;
            this.numPrecioCompra.ThousandsSeparator = true;
            this.numPrecioCompra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(110, 281);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Precio Compra ($):";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(191, 367);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(157, 23);
            this.btnGuardarCambios.TabIndex = 18;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseSelectable = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(354, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmEditorPrenda
            // 
            this.AcceptButton = this.btnGuardarCambios;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(534, 418);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.numPrecioCompra);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.numPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbTalla);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSelImagen);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditorPrenda";
            this.Text = "Nueva/Editar Prenda";
            this.Load += new System.EventHandler(this.FrmEditorPrenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSelImagen;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTextBox txtNombreProd;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroLabel lblProveedor;
        private MetroFramework.Controls.MetroComboBox cbProveedor;
        private MetroFramework.Controls.MetroLabel lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private MetroFramework.Controls.MetroLabel lblTalla;
        private MetroFramework.Controls.MetroComboBox cbTalla;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroComboBox cbCategoria;
        private MetroFramework.Controls.MetroLabel lblPrecioVenta;
        private System.Windows.Forms.NumericUpDown numPrecioVenta;
        private System.Windows.Forms.NumericUpDown numPrecioCompra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnGuardarCambios;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}