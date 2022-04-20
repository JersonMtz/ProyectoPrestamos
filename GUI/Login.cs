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
            Cursor.Current = Cursors.WaitCursor;
            var res = Afiliado.IniciarSesion(txtCardId.Text);

            if (res.Count > 0)
            {
                string pass = res.ElementAt(5).ToString();

                if (pass == txtPassword.Text)
                {
                    string nombre = $"{ res.ElementAt(2) } { res.ElementAt(3) } { res.ElementAt(4) }";
                    
                    if (res.ElementAt(6) == "P")
                    {
                        var menu = new MenuLender(res.ElementAt(0), nombre, res.ElementAt(7), this);
                        menu.Show();
                    } else
                    {
                        var menu = new MenuDebtor(res.ElementAt(0), nombre, res.ElementAt(8), this);
                        menu.Show();
                    }

                } else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            } else
            {
                MessageBox.Show("Credenciales incorrectas");
            }

            txtCardId.Text = string.Empty;
             txtPassword.Text = string.Empty;
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCardId.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                this.btnLogin.Enabled = true;
            } else
            {
                this.btnLogin.Enabled = false;
            }
        }

        private void txtCardId_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCardId.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                this.btnLogin.Enabled = true;
            }
            else
            {
                this.btnLogin.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCardId.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                this.btnLogin.Enabled = true;
            }
            else
            {
                this.btnLogin.Enabled = false;
            }
        }

        private void txtCardId_TextChanged(object sender, EventArgs e)
        {
            if (txtCardId.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                this.btnLogin.Enabled = true;
            }
            else
            {
                this.btnLogin.Enabled = false;
            }
        }
    }
}