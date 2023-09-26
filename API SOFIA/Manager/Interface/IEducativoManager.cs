using Computarizada;
using Manager.Request;
using Poco;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IEducativoManager
    {
        public Task<Resultado> RecepcionFacturaComputarizada(CompEducativaRecepcionRequest request);
        public Task<Resultado> AnulacionFactura(SolicitudAnulacion request);
        public Task<Resultado> RecepcionMasiva(ComputarizadoRecepcionMasivaRequest request);
        public Task<Resultado> RecepcionPaquete(ComputarizadoRecepcionPaqueteRequest request);
        public Task<validacionRecepcionMasivaFacturaResponse> ValidacionRecepcionMasiva(solicitudValidacionRecepcion request);
        public Task<validacionRecepcionPaqueteFacturaResponse> ValidacionRecepcionPaquete(solicitudValidacionRecepcion request);
        public Task<verificarComunicacionResponse> VerificacionComunicacion();
        public Task<verificacionEstadoFacturaResponse> VerificacionEstado(VerificacionEstado request);
    }
}
