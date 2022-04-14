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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void typePerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.typePerson.SelectedIndex == 0)
            {
                this.lblChange.Text = "Saldo";
            } else
            {
                this.lblChange.Text = "Valor de riesgo";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password1_Leave(object sender, EventArgs e)
        {
            this.password1.PasswordChar = '●';
        }

        private void password2_Leave(object sender, EventArgs e)
        {
            this.password2.PasswordChar = '●';
        }

        private void password1_Enter(object sender, EventArgs e)
        {
            this.password1.PasswordChar = '\0';
        }

        private void password2_Enter(object sender, EventArgs e)
        {
            this.password2.PasswordChar = '\0';
        }
    }
}
