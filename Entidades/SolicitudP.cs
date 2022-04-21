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

        public static List<string[]> prestamosXafiliado(string id)
        {
            string query = $"SELECT IdSolicitud, Codigo, Fecha, Motivo, " +
                $"ImporteTotal, Plazo, Interes, Estado FROM Solicitudes WHERE IdAfiliado = { id }";
            var mysql = Mysql.Init();
            var res = mysql.Select(query);

            List<string[]> lista = new List<string[]>();


            while (res.Read())
            {
                string[] row = { $"{ res["IdSolicitud"] }", $"{ res["Codigo"] }", $"{ res["Fecha"] }",
                $"{ res["Motivo"] }", $"{ res["ImporteTotal"] }", $"{ res["Plazo"] }", $"{ res["Interes"] }", 
                $"{ res["Estado"] }"};

                lista.Add(row);
            }

            mysql.Close();
            return lista;
        }

        public static List<string[]> prestamosPendientes()
        {
            string query = "SELECT SO.IdSolicitud, CONCAT(AF.Nombre, ' ', AF.PriApellido,' ', AF.SegApellido) " +
                "AS Solicitante, SO.Codigo, SO.Fecha, SO.Motivo, SO.ImporteTotal, SO.Plazo, SO.Interes," +
                "SO.Estado FROM Solicitudes AS SO INNER JOIN Afiliados AS" +
                " AF ON SO.IdAfiliado = AF.IdAfiliado WHERE SO.Estado = '0'";
            var mysql = Mysql.Init();
            var res = mysql.Select(query);

            List<string[]> lista = new List<string[]>();


            while (res.Read())
            {
                string[] row = { $"{ res["IdSolicitud"] }", $"{ res["Solicitante"] }", $"{ res["Codigo"] }", 
                    $"{ res["Fecha"] }", $"{ res["Motivo"] }", $"{ res["ImporteTotal"] }", $"{ res["Plazo"] }", 
                    $"{ res["Interes"] }", $"{ res["Estado"] }"};

                lista.Add(row);
            }

            mysql.Close();
            return lista;
        }
    }
}
