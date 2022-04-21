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
    public partial class Solicitud : Form
    {
        private MenuDebtor menu;
        public Solicitud(MenuDebtor menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            var value = DateTime.Now;
            string day = value.ToString("dddd");
            if (day == "lunes")
            {
                day = "L";
            }
            else if (day == "martes")
            {
                day = "K";
            }
            else if (day == "miércoles")
            {
                day = "M";
            }
            else if (day == "jueves")
            {
                day = "J";
            }
            else if (day == "viernes")
            {
                day = "V";
            }
            else
            {
                day = "SD";
            }

            lblCode.Text = day + value.ToString("ffff");
            lblDate.Text = value.ToString("d/MM/yyyy").Replace(",","/").Replace(" ", "");
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar la solicitud?", "Atención", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string plazo = txtPlazo.Value.ToString("yyyy-MM-dd");
                var solicitudP = new SolicitudP(menu.id, fecha, lblCode.Text, txtImporte.Text, plazo, 
                    txtInteres.Value.ToString(), txtMotivo.Text);
                solicitudP.Registrar();
                txtImporte.Text = "0";
                txtMotivo.Text = String.Empty;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.menu.Enabled = true;
            this.Close();
        }
        
        private void Solicitud_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtMotivo.Text == String.Empty)
            {
                this.menu.Enabled = true;
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("¿Desea salir?", "Atención", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.menu.Enabled = true;
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
