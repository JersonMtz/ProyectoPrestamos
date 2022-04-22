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
            this.lblSaldo.Text = "₡ " + saldo;
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
                    string estado = lista[i][8] == "False" ? "Pendiente" : "Aprobado";
                    this.listaPrestamos.Rows.Add(lista[i][0], lista[i][1], lista[i][2],
                        lista[i][3], lista[i][4], "₡ " + lista[i][5], lista[i][6], lista[i][7] + "%", estado);
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.listaPrestamos.Columns.Clear();
            this.AgregarColumnas();
            this.CargarDatos();
            Cursor = Cursors.Default;
        }

        private void listaPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblSaldo.Text == "₡ 0")
            {
                MessageBox.Show("Su saldo es de ₡ O. Usted no puede realizar más importes");
                return;
            }

            string idSolicitud = this.listaPrestamos.Rows[e.RowIndex].Cells["numero"].FormattedValue.ToString();
            string solicitante = this.listaPrestamos.Rows[e.RowIndex].Cells["solicitante"].FormattedValue.ToString();
            string prestamo = this.listaPrestamos.Rows[e.RowIndex].Cells["importeTotal"].FormattedValue.ToString();
            var respuesta = Microsoft.VisualBasic
                .Interaction.InputBox($"Ingrese la cantidad aportar para el préstamo de: { solicitante }", "Realizar Importe", "");

            try
            {
                if (respuesta.Trim() != String.Empty)
                {
                    int prestamoTotal = Int32.Parse(prestamo.Replace("₡", "").Trim());
                    int importe = Int32.Parse(respuesta);
                    int saldo = Int32.Parse(lblSaldo.Text.Replace("₡ ", ""));
                    if (importe > prestamoTotal)
                    {
                        MessageBox.Show("Importe NO realizado. El importe supera el préstamo total");
                        return;
                    }
                    
                    if (importe <= saldo)
                    {
                        var aporte = new Aporte(idSolicitud, this.id);
                        aporte.Registrar();
                        MessageBox.Show("Importe Realizado");
                    }
                    else
                    {
                        MessageBox.Show("Importe NO realizado");
                    }
                }

                return;

            } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. Contacte con el administrador. " + ex.Message);
            }
        }
    }
}
