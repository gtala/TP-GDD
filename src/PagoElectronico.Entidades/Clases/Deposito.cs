using System.Collections.Generic;

namespace PagoElectronico.Entidades.Clases
{
    public class Deposito
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


        public Deposito()
        {
            //El listado total de funcionalidades del sistema es fijo y no varía
           // this.funcionalidades = new List<Funcionalidad>();
        }
    }
}
