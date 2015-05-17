using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases
{
    public class Rol
    {
        public int idrol { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }

        public void setidrol(int id)
        {
            this.idrol = id;
        }
        public int getidrol()
        {
            return this.idrol;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getnombre()
        {
            return this.nombre;
        }
        public void setestado(int estado)
        {
            this.estado = estado;
        }
        public int getestado()
        {
            return this.estado;
        }
    }
}
