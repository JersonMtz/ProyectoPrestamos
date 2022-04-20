using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamos
{
    public partial class MenuLender : Form
    {
        private Login login;
        private string id;
        public MenuLender(string id, string nombre, string saldo, Login login)
        {
            InitializeComponent();
            this.id = id;
            this.lblUsuario.Text = nombre;
            this.lblSaldo.Text = saldo;
            this.login = login;
            this.login.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Atención", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.login.Visible = true;
                this.Close();
            }
        }
    }
}
