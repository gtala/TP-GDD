using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidades.Clases
{
    public class Pais
    {
        private int pais_Codigo;
        public int Pais_Codigo
        {
            get
            {
                return pais_Codigo;
            }
            set
            {
                pais_Codigo = value;
            }
        }

        private string pais_descripcion;
        public string Pais_Descipcion
        {
            get
            {
                return pais_descripcion;
            }
            set
            {
                pais_descripcion = value;
            }
        }
    }
}
