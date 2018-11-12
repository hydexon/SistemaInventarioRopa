namespace SistemaInventarioRopa_Desktop
{
    partial class FrmNuevaCategoria
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
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.lblNuevaCategoria = new MetroFramework.Controls.MetroLabel();
            this.txtNuevaCat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(505, 225);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(424, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Location = new System.Drawing.Point(66, 108);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(111, 19);
            this.lblNuevaCategoria.TabIndex = 2;
            this.lblNuevaCategoria.Text = "Nueva Categoria:";
            // 
            // txtNuevaCat
            // 
            // 
            // 
            // 
            this.txtNuevaCat.CustomButton.Image = null;
            this.txtNuevaCat.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.txtNuevaCat.CustomButton.Name = "";
            this.txtNuevaCat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNuevaCat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevaCat.CustomButton.TabIndex = 1;
            this.txtNuevaCat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevaCat.CustomButton.UseSelectable = true;
            this.txtNuevaCat.CustomButton.Visible = false;
            this.txtNuevaCat.Lines = new string[0];
            this.txtNuevaCat.Location = new System.Drawing.Point(183, 108);
            this.txtNuevaCat.MaxLength = 32767;
            this.txtNuevaCat.Name = "txtNuevaCat";
            this.txtNuevaCat.PasswordChar = '\0';
            this.txtNuevaCat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevaCat.SelectedText = "";
            this.txtNuevaCat.SelectionLength = 0;
            this.txtNuevaCat.SelectionStart = 0;
            this.txtNuevaCat.ShortcutsEnabled = true;
            this.txtNuevaCat.Size = new System.Drawing.Size(370, 23);
            this.txtNuevaCat.TabIndex = 3;
            this.txtNuevaCat.UseSelectable = true;
            this.txtNuevaCat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevaCat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Firebrick;
            this.metroLabel1.Location = new System.Drawing.Point(183, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ERROR: La categoria ya existe";
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Visible = false;
            // 
            // FrmNuevaCategoria
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(603, 271);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNuevaCat);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevaCategoria";
            this.Resizable = false;
            this.Text = "Nueva Categoria";
            this.Load += new System.EventHandler(this.FrmNuevaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroLabel lblNuevaCategoria;
        private MetroFramework.Controls.MetroTextBox txtNuevaCat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}