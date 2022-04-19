using MySql.Data.MySqlClient;
using System.Data;
using ProyectoPrestamos.Entidades;

namespace ProyectoPrestamos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var res = Afiliado.IniciarSesion(txtCardId.Text);

            if (res.Count > 0)
            {
                string pass = res.ElementAt(5).ToString();

                if (pass == txtPassword.Text)
                {
                    MessageBox.Show("Pase");
                } else
                {
                    MessageBox.Show("NO Pase");
                }
            } else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Show();
        }

        private void txtCardId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}