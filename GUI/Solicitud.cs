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
    public partial class Solicitud : Form
    {
        public Solicitud()
        {
            InitializeComponent();
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
            else if (day == "miercoles")
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
    }
}
