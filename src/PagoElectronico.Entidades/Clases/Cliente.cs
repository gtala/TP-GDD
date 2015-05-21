using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Entidades.Clases
{
    public class Cliente
    {
        public Cliente()
        {
            this.Pais = new Pais();
        }
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

        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private string apellido;
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        private int tipo_Doc_Codigo;
        public int Tipo_Doc_Codigo
        {
            get
            {
                return tipo_Doc_Codigo;
            }
            set
            {
                tipo_Doc_Codigo = value;
            }
        }

        private int nro_Documento;
        public int Nro_Documento
        {
            get
            {
                return nro_Documento;
            }
            set
            {
                nro_Documento = value;
            }
        }

        private string tipo_Doc_Desc;
        public string Tipo_Doc_Desc
        {
            get
            {
                return tipo_Doc_Desc;
            }
            set
            {
                tipo_Doc_Desc = value;
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

        private string domicilio_Calle;
        public string Domicilio_Calle
        {
            get
            {
                return domicilio_Calle;
            }
            set
            {
                domicilio_Calle = value;
            }
        }

        private int domicilio_Nro;
        public int Domicilio_Nro
        {
            get
            {
                return domicilio_Nro;
            }
            set
            {
                domicilio_Nro = value;
            }
        }

        private int domicilio_Piso;
        public int Domicilio_Piso
        {
            get
            {
                return domicilio_Piso;
            }
            set
            {
                domicilio_Piso = value;
            }
        }

        private string domicilio_Depto;
        public string Domicilio_Depto
        {
            get
            {
                return domicilio_Depto;
            }
            set
            {
                domicilio_Depto = value;
            }
        }

        private DateTime fecha_Nacimineto;
        public DateTime Fecha_Nacimiento
        {
            get
            {
                return fecha_Nacimineto;
            }
            set
            {
                fecha_Nacimineto = value;
            }
        }

        private string mail;
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }

    }
}
