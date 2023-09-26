using CreditoDebito;
using Manager.Request;
using Poco;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface ICreditoDebitoManager
    {
        public Task<anulacionDocumentoAjusteResponse> AnulacionFactura(SolicitudAnulacion request);
        public Task<Resultado> RecepcionFactura(CompDebitoCreditoRecepcionRequest request);
        public Task<verificarComunicacionResponse> VerificacionComunicacion(verificarComunicacion request);
        public Task<verificacionEstadoDocumentoAjusteResponse> VerificacionEstado(VerificacionEstado request);
    }
}
