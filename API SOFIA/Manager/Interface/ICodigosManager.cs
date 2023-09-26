using Codigos;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface ICodigosManager
    {
        public Task<cufdResponse> SolicitudCufd(solicitudCufd request, string token);
        public Task<cufdMasivoResponse> SolicitudCufdMasivo(solicitudCufdMasivo request, string token);
        public Task<cuisResponse> SolicitudCuis(solicitudCuis request, string token);
        public Task<cuisMasivoResponse> SolicitudCuisMasivo(solicitudCuisMasivoSistemas request, string token);
        public Task<verificarNitResponse> VerificarNit(solicitudVerificarNit request, string token);
    }
}
