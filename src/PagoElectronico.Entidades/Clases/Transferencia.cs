using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidades.Clases
{
    public class Transferencia
    {
        private int nroOperacion;
        public int NroOperacion
        {
            get
            {
                return nroOperacion;
            }
            set
            {
                nroOperacion = value;
            }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        private double importe;
        public double Importe
        {
            get
            {
                return importe;
            }
            set
            {
                importe = value;
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

        private long cuentaOrigen;
        public long CuentaOrigen
        {
            get
            {
                return cuentaOrigen;
            }
            set
            {
                cuentaOrigen = value;
            }
        }

        private long cuentaDestino;
        public long CuentaDestino
        {
            get
            {
                return cuentaDestino;
            }
            set
            {
                cuentaDestino = value;
            }
        }
    }
}
