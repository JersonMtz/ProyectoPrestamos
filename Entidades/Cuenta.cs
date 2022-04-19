using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrestamos.Interfaces;
using ProyectoPrestamos.DB;

namespace ProyectoPrestamos.Entidades
{
    public class Cuenta: IEntidad
    {
        public int idCuenta { get; set; }
        public int idAfiliado { get; set; }
        public int saldo { get; set; }
        public int valorRiesgo { get; set; }

        public Cuenta(int saldo, int valorRiesgo)
        {
            this.idAfiliado = 0;
            this.saldo = saldo;
            this.valorRiesgo = valorRiesgo;
            this.idCuenta = 0;
        }

        public string[] toString()
        {
            string[] data = { "Cuentas", $"{ this.idAfiliado },{ this.saldo },{ this.valorRiesgo }" };
            return data;
        }

        public void Registrar()
        {
            var mysql = Mysql.Init();
            var res = mysql.Insert(this);
            if (!res)
            {
                MessageBox.Show("No se pudo crear cuenta, contacte con el administrador");
            }
        }

        public void Actualizar()
        {
            Console.WriteLine("Actualizar Cuenta");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminar Cuenta");
        }
    }
}
