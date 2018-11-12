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
    public partial class FrmEditorEmpleados : MetroForm
    {
        private int CodActual = -1;
        private bool Editando = false;

        public FrmEditorEmpleados()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            txtNombres.Clear();
            txtPassword.Clear();
            txtPasswordConfirm.Clear();
            txtUsername.Clear();
            mtbDUI.Clear();
            rbUserAdmin.Checked = false;
            rbUserStandard.Checked = false;
        }

        private bool PasswordCoinciden()
        {
            return txtPasswordConfirm.Text.Equals(txtPassword.Text, StringComparison.CurrentCulture);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombres.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo del nombre del empleado no puede estar vacio!");
                return;
            }

            if (!(String.IsNullOrEmpty(txtPassword.Text) && String.IsNullOrEmpty(txtPasswordConfirm.Text))) // Si los campos no estan vacios.
            {
                if (!PasswordCoinciden())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden!");
                    return;
                }
            }

            if(!(rbUserStandard.Checked || rbUserStandard.Checked))
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe seleccionar el tipo de usuario primero antes de continuar!");
                return;
            }

            int userType = 0;
            if (rbUserAdmin.Checked) userType = 0;
            if (rbUserStandard.Checked) userType = 1;

            Dictionary<string, object> datos = new Dictionary<string, object>
            {
                { "@Nombres", txtNombres.Text  },
                { "@DUI", mtbDUI.Text },
                { "@UserName", txtUsername.Text },
                { "@UserType", userType }
            };

            if(!(String.IsNullOrEmpty(txtPassword.Text) && String.IsNullOrEmpty(txtPasswordConfirm.Text)) && PasswordCoinciden())
            {
                datos.Add("@Password", txtPassword.Text);
            }

            if (Editando) datos.Add("@Id", CodActual);
            bool resultado = (Editando ? GestionUsuarios.Instancia.ModificarUsuario(datos) : GestionUsuarios.Instancia.CrearNuevoUsuario(datos));
            DialogResult = (resultado ? DialogResult.OK : DialogResult.Cancel);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public DialogResult NuevoEmpleado()
        {
            Editando = false;
            LimpiarControles();
            Text = "Agregando Empleado";

            return ShowDialog();
        }

        public DialogResult EditarEmpleado(int cod)
        {
            CodActual = cod;
            Editando = true;
            Text = "Editando Empleado";
            LimpiarControles();
            Dictionary<string, object> datos = GestionUsuarios.Instancia.ObtenerEmpleado(cod);
            txtNombres.Text = datos["Nombre"].ToString();
            txtUsername.Text = datos["Username"].ToString();
            mtbDUI.Text = datos["DUI"].ToString();

            int userType = Convert.ToInt32(datos["TipoUser"]);
            if (userType == 0) rbUserAdmin.Checked = true; else rbUserStandard.Checked = true;
          
            return ShowDialog();
        }
    }
}
