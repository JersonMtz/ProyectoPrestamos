using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoPrestamos.Entidades;

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
                this.lblRiesgo.Visible = false;
            } else
            {
                this.lblChange.Text = "Valor de riesgo";
                this.lblRiesgo.Visible = true;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" || txtNombre.Text == "" || txtPriApellido.Text == "" || txtChange.Text == "" || password1.Text == "" || password2.Text == "" || typePerson.Text == "")
            {
                MessageBox.Show("Por favor ingrese los datos requeridos");
                return;
            }

            if (this.password1.Text != this.password2.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales");
                return;
            }

            int cedula = 0;
            try
            {
                cedula = Int32.Parse(txtCedula.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{ cedula }'");
            }

            char type = this.typePerson.Text == "Deudor" ? 'D' : 'P';
            int valor = Int32.Parse(this.txtChange.Text);

            if (this.typePerson.Text == "Deudor")
            {
                var persona = new Afiliado(cedula, txtNombre.Text, txtPriApellido.Text, 
                  txtSegApellido.Text, 'D', password1.Text, 0, valor);
                persona.Registrar();
            } else
            {
                var persona = new Afiliado(cedula, txtNombre.Text, txtPriApellido.Text,
                  txtSegApellido.Text, 'P', password1.Text, valor, 0);
                persona.Registrar();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
