using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Negocio.Helpers
{
    public class UtilNegocio
    {
        public DataTable ObtenerTipoDocumento()
        {
            Datos.Helpers.UtilDatos util = new PagoElectronico.Datos.Helpers.UtilDatos();
            return util.ObtenerTiposDocumento();
        }

        public List<Moneda> ObtenerMonedas()
        {
            DataTable dtMonedas;
            Datos.Helpers.UtilDatos util = new PagoElectronico.Datos.Helpers.UtilDatos();
            dtMonedas = util.ObtenerMonedas();
            List<Moneda> lstMonedas = dtMonedas.AsEnumerable().Select(x => new Moneda()
            {
                Codigo = Convert.ToInt32(Convert.ToString(x["Moneda_Tipo"])),
                Descipcion = Convert.ToString(x["Moneda_Desc"] ?? string.Empty)
            }).ToList();
            return lstMonedas;
        }

        public void GuardarAuditoriaLogin(string username, bool accesoCorrecto, int numeroIntento)
        {
            Datos.Helpers.UtilDatos util = new PagoElectronico.Datos.Helpers.UtilDatos();
            util.GuardarAuditoriaLogin(username, accesoCorrecto, numeroIntento);
        }

        public List<TipoCuenta> ObtenerTiposCuenta()
        {
            DataTable dtTipoCuenta;
            Datos.Helpers.UtilDatos util = new PagoElectronico.Datos.Helpers.UtilDatos();
            dtTipoCuenta = util.ObtenerTipoCuenta();
            List<TipoCuenta> lstTiposCuenta= dtTipoCuenta.AsEnumerable().Select(x => new TipoCuenta()
            {
                Codigo = Convert.ToInt32(Convert.ToString(x["Tipo_Cuenta_Tipo"])),
                Descipcion = Convert.ToString(x["Tipo_Cuenta_Desc"] ?? string.Empty)
            }).ToList();
            return lstTiposCuenta;
        }
    }
}
