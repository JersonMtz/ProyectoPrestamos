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
            Console.Write("Hello World");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Show();
        }
    }
}