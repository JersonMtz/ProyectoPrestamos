using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrestamos.DB;
using ProyectoPrestamos.Interfaces;

namespace ProyectoPrestamos.Entidades
{
    public class Aporte: IEntidad
    {
        public string idAporte { get; set; }
        public string idSolicitud { get; set; }
        public string idAfiliado { get; set; }
        public string importe { get; set; }

        public Aporte(string idSolicitud, string Afiliado)
        {
            this.idSolicitud = idSolicitud;
            this.idAfiliado = Afiliado;
            this.importe = "0";
            this.idAporte = "0";
        }

        public void Registrar()
        {
            var mysql = Mysql.Init();
            var res = mysql.Insert(this);
            if (!res)
            {
                MessageBox.Show("No se pudo crear el importe, contacte con el administrador");
            }
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        public string[] toString()
        {
            string[] data = { "Aportes",  $"{ this.idSolicitud },{ this.idAfiliado },{ this.importe }" };
            return data;
        }
    }
}
