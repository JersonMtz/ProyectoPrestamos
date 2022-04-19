using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrestamos.DB;
using ProyectoPrestamos.Interfaces;

namespace ProyectoPrestamos.Entidades
{
    public class Afiliado: IEntidad
    {
        private int idAfiliado;
        private int cedula;
        private string nombre;
        private string priApellido;
        private string segApellido;
        private char tipo;
        private Usuario usuario;
        private Cuenta cuenta;

        public Afiliado(int cedula, string nombre, string priApellido, string segApellido, 
            char tipo, string contrasenna, int saldo, int valorRiesgo, int idAfiliado = 0)
        {
            this.idAfiliado = idAfiliado;
            this.cedula = cedula;
            this.nombre = nombre;
            this.priApellido = priApellido;
            this.segApellido = segApellido;
            this.tipo = tipo;

            this.usuario = new Usuario(contrasenna);
            this.cuenta = new Cuenta(saldo, valorRiesgo);
        }

        public string[] toString()
        {
            string[] data = { "Afiliados", $"{ this.cedula }, '{ this.nombre }','{ this.priApellido }','{ this.segApellido }','{ this.tipo }'" };
            return data;
        }

        public static List<string> IniciarSesion(string cedula)
        {
            string query = "SELECT af.IdAfiliado, af.Cedula, af.Nombre, af.PriApellido, af.SegApellido, us.Contrasenna, af.Tipo, cu.Saldo, " +
                "cu.ValorRiesgo FROM Afiliados AS af INNER JOIN Usuarios AS us " +
                "ON af.IdAfiliado = us.IdAfiliado INNER JOIN Cuentas AS cu on cu.IdAfiliado = af.IdAfiliado WHERE af.Cedula =" + $"{ cedula }";
            
            var mysql = Mysql.Init();
            var res = mysql.Select(query);
            List<string> result = new List<string>();

            while(res.Read())
            {
                result.Add($"{ res["IdAfiliado"] }");
                result.Add($"{ res["Cedula"] }");
                result.Add($"{ res["Nombre"] }");
                result.Add($"{ res["PriApellido"] }");
                result.Add($"{ res["SegApellido"] }");
                result.Add($"{ res["Contrasenna"] }");
                result.Add($"{ res["Tipo"] }");
                result.Add($"{ res["Saldo"] }");
                result.Add($"{ res["ValorRiesgo"] }");
            }

            return result;
        }

        public void Registrar()
        {
            var mysql = Mysql.Init();

            if (mysql.Insert(this))
            {
                int id = this.getIdAfiliado();
                if (id != 0)
                {
                    this.usuario.idAfiliado = id;
                    this.usuario.Registrar();

                    this.cuenta.idAfiliado = id;
                    this.cuenta.Registrar();

                    MessageBox.Show("Registro realizado con éxito");
                }

            }
        }

        public void Actualizar()
        {

        }

        public void Eliminar()
        {

        }

        private int getIdAfiliado()
        {
            int id = 0;
            var mysql = Mysql.Init();
            var res = mysql.Select($"SELECT IdAfiliado FROM { this.toString()[0] } WHERE Cedula={ this.cedula }");

            while (res.Read())
            {
                id = Int32.Parse($"{ res["IdAfiliado"] }"); 
            }

            mysql.Close();
            return id;
        }

        public void Listar()
        {
            
        }


    }
}
