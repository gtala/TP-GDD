using System.Collections.Generic;
using PagoElectronico.Entidades;
using System;

namespace PagoElectronico.Entidades.Clases
{
    public class Cuenta
    {

        private long numero;
        public long Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        private DateTime fechaCreacion;
        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        private DateTime fechaCierre;
        public DateTime FechaCierre
        {
            get
            {
                return fechaCierre;
            }
            set
            {
                fechaCierre = value;
            }
        }

        private EstadoCuenta estado;
        public EstadoCuenta Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        private Pais pais;
        public Pais Pais
        {
            get
            {
                return pais;
            }
            set
            {
                pais = value;
            }
        }


        private int monedaCodigo;
        public int MonedaCodigo
        {
            get
            {
                return monedaCodigo;
            }
            set
            {
                monedaCodigo = value;
            }
        }
        private string moneda;
        public string Moneda
        {
            get
            {
                return moneda;
            }
            set
            {
                moneda = value;
            }
        }

        private TipoCuenta tipo;
        public TipoCuenta Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }

        private int cliente;
        public int Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        public TipoEstado Tipo_Estado
        {
            get
            {
                switch (estado.Codigo)
                {
                    case 1: return TipoEstado.PENDIENTE;
                    case 2: return TipoEstado.CERRADA;
                    case 3: return TipoEstado.INHABILITADA;
                    case 4: return TipoEstado.HABILITADA;
                    default: return TipoEstado.INHABILITADA;
                }
            }
        }
        public string EstadoCuenta
        {
            get
            {
                return estado.Descipcion;
            }
        }
        public string PaisCuenta
        {
            get
            {
                return pais.Descipcion;
            }
        }
        public string TipoCuenta
        {
            get
            {
                return tipo.Descipcion;
            }
        }
        public double TipoCuenta_Costo
        {
            get { 
                return tipo.Costo;
            }
        }


        public Cuenta()
        {

        }
    }
}
