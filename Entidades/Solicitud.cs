using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrestamos.Interfaces;

namespace ProyectoPrestamos.Entidades
{
    public class Solicitud: IEntidad
    {
        public int idSolicitud { get; set; }
        public int idAfiliado { get; set; }
        public DateTime fecha { get; set; }
        public string codigo { get; set; }
        public int importeTotal { get; set; }
        public DateTime plazo { get; set; }
        public int interes { get; set; }
        public string motivo { get; set; }

        public void Registrar()
        {

        }

        public string[] toString()
        {
            return new string[2];
        }

        public void Actualizar()
        {

        }

        public void Eliminar()
        {

        }
    }
}
