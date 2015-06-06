using System.Collections.Generic;

namespace PagoElectronico.Entidades.Clases
{
    public class Cuenta
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

        private List<Funcionalidad> funcionalidades;
        public List<Funcionalidad> Funcionalidades
        {
            get
            {
                return funcionalidades;
            }
            set
            {
                funcionalidades = value;
            }
        }

        private bool estado;
        public bool Estado
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

        public string EstadoString
        {
            get
            {
                return estado ? "Inhabilitado" : "Habilitado";
            }
        }

        public Cuenta()
        {
            //El listado total de funcionalidades del sistema es fijo y no varía
            this.funcionalidades = new List<Funcionalidad>();
        }
    }
}
