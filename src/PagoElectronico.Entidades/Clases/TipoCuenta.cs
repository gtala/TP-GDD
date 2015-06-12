using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidades.Clases
{
    public class TipoCuenta
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

        private int diasDuracion;
        public int DiasDuracion
        {
            get
            {
                return diasDuracion;
            }
            set
            {
                diasDuracion = value;
            }
        }

        private double costo;
        public double Costo
        {
            get
            {
                return costo;
            }
            set
            {
                costo = value;
            }
        }
    }
}
