namespace SistemaInventarioRopa_Desktop
{
    partial class FrmEditorEmpleados
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
            this.lblNombreReal = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.mtbDUI = new System.Windows.Forms.MaskedTextBox();
            this.lblDUI = new MetroFramework.Controls.MetroLabel();
            this.lblTipoUsuario = new MetroFramework.Controls.MetroLabel();
            this.rbUserAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.rbUserStandard = new MetroFramework.Controls.MetroRadioButton();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblConfirmPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPasswordConfirm = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.Location = new System.Drawing.Point(61, 85);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(91, 19);
            this.lblNombreReal.TabIndex = 0;
            this.lblNombreReal.Text = "Nombre Real:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nombre de Usuario:";
            // 
            // txtNombres
            // 
            // 
            // 
            // 
            this.txtNombres.CustomButton.Image = null;
            this.txtNombres.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtNombres.CustomButton.Name = "";
            this.txtNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombres.CustomButton.TabIndex = 1;
            this.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombres.CustomButton.UseSelectable = true;
            this.txtNombres.CustomButton.Visible = false;
            this.txtNombres.Lines = new string[] {
        "metroTextBox1"};
            this.txtNombres.Location = new System.Drawing.Point(158, 85);
            this.txtNombres.MaxLength = 32767;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.ShortcutsEnabled = true;
            this.txtNombres.Size = new System.Drawing.Size(276, 23);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.Text = "metroTextBox1";
            this.txtNombres.UseSelectable = true;
            this.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[] {
        "metroTextBox2"};
            this.txtUsername.Location = new System.Drawing.Point(158, 140);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(276, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "metroTextBox2";
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbDUI
            // 
            this.mtbDUI.Location = new System.Drawing.Point(158, 114);
            this.mtbDUI.Mask = "99999999-9";
            this.mtbDUI.Name = "mtbDUI";
            this.mtbDUI.Size = new System.Drawing.Size(276, 20);
            this.mtbDUI.TabIndex = 5;
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(119, 114);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(33, 19);
            this.lblDUI.TabIndex = 4;
            this.lblDUI.Text = "DUI:";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(47, 169);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(105, 19);
            this.lblTipoUsuario.TabIndex = 6;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // rbUserAdmin
            // 
            this.rbUserAdmin.AutoSize = true;
            this.rbUserAdmin.Location = new System.Drawing.Point(158, 173);
            this.rbUserAdmin.Name = "rbUserAdmin";
            this.rbUserAdmin.Size = new System.Drawing.Size(99, 15);
            this.rbUserAdmin.TabIndex = 7;
            this.rbUserAdmin.Text = "Administrador";
            this.rbUserAdmin.UseSelectable = true;
            // 
            // rbUserStandard
            // 
            this.rbUserStandard.AutoSize = true;
            this.rbUserStandard.Location = new System.Drawing.Point(158, 195);
            this.rbUserStandard.Name = "rbUserStandard";
            this.rbUserStandard.Size = new System.Drawing.Size(68, 15);
            this.rbUserStandard.TabIndex = 8;
            this.rbUserStandard.Text = "Estandar";
            this.rbUserStandard.UseSelectable = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(74, 221);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(10, 252);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(142, 19);
            this.lblConfirmPassword.TabIndex = 10;
            this.lblConfirmPassword.Text = "Confirmar Contraseña:";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[] {
        "metroTextBox3"};
            this.txtPassword.Location = new System.Drawing.Point(158, 221);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(276, 23);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "metroTextBox3";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPasswordConfirm
            // 
            // 
            // 
            // 
            this.txtPasswordConfirm.CustomButton.Image = null;
            this.txtPasswordConfirm.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.txtPasswordConfirm.CustomButton.Name = "";
            this.txtPasswordConfirm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordConfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordConfirm.CustomButton.TabIndex = 1;
            this.txtPasswordConfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordConfirm.CustomButton.UseSelectable = true;
            this.txtPasswordConfirm.CustomButton.Visible = false;
            this.txtPasswordConfirm.Lines = new string[] {
        "metroTextBox4"};
            this.txtPasswordConfirm.Location = new System.Drawing.Point(159, 252);
            this.txtPasswordConfirm.MaxLength = 32767;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '●';
            this.txtPasswordConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordConfirm.SelectedText = "";
            this.txtPasswordConfirm.SelectionLength = 0;
            this.txtPasswordConfirm.SelectionStart = 0;
            this.txtPasswordConfirm.ShortcutsEnabled = true;
            this.txtPasswordConfirm.Size = new System.Drawing.Size(275, 23);
            this.txtPasswordConfirm.TabIndex = 12;
            this.txtPasswordConfirm.Text = "metroTextBox4";
            this.txtPasswordConfirm.UseSelectable = true;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            this.txtPasswordConfirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordConfirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(307, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmEditorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 390);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.rbUserStandard);
            this.Controls.Add(this.rbUserAdmin);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.mtbDUI);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblNombreReal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditorEmpleados";
            this.Resizable = false;
            this.Text = "Nuevo/Editar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombreReal;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.MaskedTextBox mtbDUI;
        private MetroFramework.Controls.MetroLabel lblDUI;
        private MetroFramework.Controls.MetroLabel lblTipoUsuario;
        private MetroFramework.Controls.MetroRadioButton rbUserAdmin;
        private MetroFramework.Controls.MetroRadioButton rbUserStandard;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblConfirmPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtPasswordConfirm;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}