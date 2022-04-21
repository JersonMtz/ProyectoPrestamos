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

            this.AgregarColumnas();
        }

        private void AgregarColumnas()
        {
            this.listaPrestamos.Columns.Add("numero", "Número");
            this.listaPrestamos.Columns.Add("solicitante", "Solicitante");
            this.listaPrestamos.Columns.Add("codigo", "Código");
            this.listaPrestamos.Columns.Add("fecha", "Fecha");
            this.listaPrestamos.Columns.Add("motivo", "Motivo");
            this.listaPrestamos.Columns.Add("importeTotal", "Importe Total");
            this.listaPrestamos.Columns.Add("plazo", "Plazo");
            this.listaPrestamos.Columns.Add("interes", "Interés");
            this.listaPrestamos.Columns.Add("estado", "Estado");
        }

        private void CargarDatos()
        {
            var lista = SolicitudP.prestamosPendientes();
            if (lista.Count > 0)
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    string estado = lista[i][7] == "False" ? "Pendiente" : "Aprobado";
                    this.listaPrestamos.Rows.Add(lista[i][0], lista[i][1], lista[i][2],
                        lista[i][3], lista[i][4], lista[i][5], lista[i][6], lista[i][7], lista[i][8]);
                }

            }

            this.login.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuLender_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Atención", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.login.Visible = true;
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MenuLender_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
    }
}
