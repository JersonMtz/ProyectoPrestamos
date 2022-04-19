using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrestamos.Interfaces;
using ProyectoPrestamos.DB;

namespace ProyectoPrestamos.Entidades
{
    public class Usuario: IEntidad
    {
        public int idUsuario { get; set; }
        public int idAfiliado { get; set; }
        public string contrasenna { get; set; }

        public Usuario(string contrasenna)
        {
            this.idAfiliado = 0;
            this.contrasenna = contrasenna;
            this.idUsuario = 0;
        }

        public string[] toString()
        {
            string[] data = { "Usuarios", $"{ this.idAfiliado }, '{ this.contrasenna }'" };
            return data;
        }

        public void Registrar()
        {
            var mysql = Mysql.Init();
            var res = mysql.Insert(this);
            if (!res)
            {
                MessageBox.Show("No se pudo crear usuario, contacte con el administrador");
            }
        }

        public void Actualizar()
        {
            Console.WriteLine("Actualizar Usuario");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminar Usuario");
        }
    }
}
