using Operaciones;
using Poco;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface IOperacionesManager
    {
        public Task<cierreOperacionesSistemaResponse> CierreOperacionesSistema(solicitudOperaciones request, string token);
        public Task<cierrePuntoVentaResponse> CierrePuntosVenta(solicitudCierrePuntoVenta request, string token);
        public Task<consultaEventoSignificativoResponse> ConsultaEventoSignificativo(solicitudConsultaEvento request, string token);
        public Task<consultaPuntoVentaResponse> ConsultaPuntoVenta(solicitudConsultaPuntoVenta request, string token);
        public Task<registroEventoSignificativoResponse> RegistroEventoSignificativo(solicitudEventoSignificativo request, string token);
        public Task<registroPuntoVentaResponse> RegistroPuntosVenta(solicitudRegistroPuntoVenta request, string token);
    }
}
