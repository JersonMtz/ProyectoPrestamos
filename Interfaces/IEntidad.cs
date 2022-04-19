using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamos.Interfaces
{
    public interface IEntidad
    {
        public void Registrar();
        
        public void Actualizar();
        
        public void Eliminar();
        
        //public void Registrar();
        
        public string[] toString();
    }
}
