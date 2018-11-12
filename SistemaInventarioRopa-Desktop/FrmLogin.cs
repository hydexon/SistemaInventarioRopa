using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventarioRopa_Desktop
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        private GestionUsuarios gestorUsuarios;

        public FrmLogin()
        {
            InitializeComponent();
            gestorUsuarios = GestionUsuarios.Instancia;
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Si no tenemos ningun usuario creado (la base de datos está vacia, debemos crear un usuario administrador por defecto):
            gestorUsuarios.GenerarCuentaAdminPorDefecto();
        }

        private void tileIngresar_Click(object sender, EventArgs e)
        {
            if(gestorUsuarios.VerificarLogin(mtxtUsuario.Text, mtxtPassword.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"El nombre de usuario o contraseña no son validos!, por favor asegurese de los datos ingresados sean correctos",
                    "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void tileSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
