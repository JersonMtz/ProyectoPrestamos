using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrestamos.Interfaces;
using ProyectoPrestamos.DB;

namespace ProyectoPrestamos.Entidades
{
    public class SolicitudP: IEntidad
    {
        public string idSolicitud { get; set; }
        public string idAfiliado { get; set; }
        public string fecha { get; set; }
        public string codigo { get; set; }
        public string importeTotal { get; set; }
        public string plazo { get; set; }
        public string interes { get; set; }
        public string motivo { get; set; }

        public SolicitudP(string idAfiliado, string fecha, string codigo,
            string importeTotal, string plazo, string interes, string motivo)
        {
            this.idAfiliado = idAfiliado;
            this.fecha = fecha;
            this.codigo = codigo;
            this.importeTotal = importeTotal;
            this.plazo = plazo;
            this.interes = interes;
            this.motivo = motivo;
            this.idSolicitud = "0";
        }

        public void Registrar()
        {
            var mysql = Mysql.Init();

            if (mysql.Insert(this))
            {
                MessageBox.Show("Solicitud realizada");
            }
        }

        public string[] toString()
        {
            string campos = $"{ this.idAfiliado }, '{ this.fecha }','{ this.codigo }',{ this.importeTotal },'{ this.plazo }',{ this.interes },'{ this.motivo }','0'";
            string[] data = { "Solicitudes", campos };
            return data;
        }

        public void Actualizar()
        {

        }

        public void Eliminar()
        {

        }
    }
}
