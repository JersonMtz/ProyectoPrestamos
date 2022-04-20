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
    public partial class MenuDebtor : Form
    {
        private Login login;
        public string id;

        public MenuDebtor(string id, string nombre, string valorRiesgo, Login login)
        {
            InitializeComponent();
            this.id = id;
            this.lblUsuario.Text = nombre;
            this.lblValorRiesgo.Text = valorRiesgo;
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

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            var solicitud = new Solicitud(this);
            solicitud.Show();
            this.Enabled = false;
        }
    }
}
