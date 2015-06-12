using PagoElectronico.Datos.Clases;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.Negocio.Clases
{
    public class TransferenciaNegocio
    {
        Datos.Clases.TransferenciaDatos miTransferenciaDatos;

        //public List<Transferencia> ObtenerTransferencias(Dictionary<string, object> filtros)
        //{
        //    try
        //    {
        //        miTransferenciaDatos = new TransferenciaDatos();
        //        return miTransferenciaDatos.ObtenerTransferencias(filtros);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void GuardarTransferencia(Transferencia transferencia)
        {
            try
            {
                miTransferenciaDatos = new TransferenciaDatos();
                miTransferenciaDatos.GuardarTransferencia(transferencia);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        //public void EliminarTransferencia(int codigoTransferencia)
        //{
        //    miTransferenciaDatos = new TransferenciaDatos();
        //    miTransferenciaDatos.EliminarTransferencia(codigoTransferencia);
        //}
    }
}
