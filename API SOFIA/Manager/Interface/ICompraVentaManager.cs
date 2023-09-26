using CompraVenta;
using Manager.Request;
using Poco;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface ICompraVentaManager
    {
        public Task<Resultado> RecepcionFacturaComputarizada(ComputarizadaRecepcionRequest request);
        public Task<anulacionFacturaResponse> AnulacionFactura(SolicitudAnulacion request);
        public Task<recepcionMasivaFacturaResponse> RecepcionMasiva(CompraVentaRecepcionMasivaRequest request);
        public Task<recepcionPaqueteFacturaResponse> RecepcionPaquete(CompraVentaRecepcionPaqueteRequest request);
        public Task<validacionRecepcionMasivaFacturaResponse> ValidacionRecepcionMasiva(solicitudValidacionRecepcion request);
        public Task<validacionRecepcionPaqueteFacturaResponse> ValidacionRecepcionPaquete(solicitudValidacionRecepcion request);
        public Task<verificarComunicacionResponse> VerificacionComunicacion();
        public Task<verificacionEstadoFacturaResponse> VerificacionEstado(VerificacionEstado request);
    }
}
