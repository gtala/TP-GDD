using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidades.Clases
{
    public class Moneda
    {

        private int codigo;
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        private string descripcion;
        public string Descipcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
    }
}
