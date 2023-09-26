using Poco;
using System;

namespace Manager.Request
{
    public static class RespuestaUtils
    {
        public static Resultado FormatResponse(object response, string cuf, string xml, DateTime? sentDate)
        {
            Resultado result = new Resultado();
            try
            {
                switch (response)
                {
                    case CompraVenta.respuestaRecepcion recepcion:
                        var convertido = response as CompraVenta.respuestaRecepcion;
                        result.Correcto = convertido.transaccion;
                        result.CodigoResultado = convertido.codigoEstado;
                        result.DatoAdicional = CheckAdditionalData(response, cuf, xml, sentDate);
                        break;
                    case Computarizada.respuestaRecepcion recepcion:
                        var convertidoComp = response as Computarizada.respuestaRecepcion;
                        result.Correcto = convertidoComp.transaccion;
                        result.CodigoResultado = convertidoComp.codigoEstado;
                        result.DatoAdicional = CheckAdditionalData(response, cuf, xml, sentDate);
                        break;
                    case CreditoDebito.respuestaRecepcion recepcion:
                        var convertidoCred = response as CreditoDebito.respuestaRecepcion;
                        result.Correcto = convertidoCred.transaccion;
                        result.CodigoResultado = convertidoCred.codigoEstado;
                        result.DatoAdicional = CheckAdditionalData(response, cuf, xml, sentDate);
                        break;
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        private static object CheckAdditionalData(dynamic response, string cuf, string xml, DateTime? sentDate)
        {
            dynamic obtainedResponse;
            if (response.codigoEstado != 908)
                obtainedResponse = response.mensajesList;
            else
                obtainedResponse = new { response.codigoRecepcion, cuf, xml, sentDate };

            return obtainedResponse;
        }
    }
}