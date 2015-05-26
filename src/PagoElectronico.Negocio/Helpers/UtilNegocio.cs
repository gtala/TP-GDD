using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.Negocio.Helpers
{
    public class UtilNegocio
    {
        public DataTable ObtenerTipoDocumento()
        {
            Datos.Helpers.UtilDatos util = new PagoElectronico.Datos.Helpers.UtilDatos();
            return util.ObtenerTiposDocumento();
        }
    }
}
