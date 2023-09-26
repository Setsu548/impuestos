using Manager.Interface;
using Microsoft.Extensions.Configuration;
using Operaciones;
using Poco;
using System.ServiceModel;
using System.Threading.Tasks;
using Utils;

namespace Manager.Implementacion
{
    public class OperacionesManager: IOperacionesManager
    {
        private readonly ServicioFacturacionOperacionesClient client;
        private readonly IConfiguration _configuration;

        public OperacionesManager(IConfiguration configuration)
        {
            _configuration = configuration;
            var binding = TokenConsumer.GenerateBinding();
            client = new ServicioFacturacionOperacionesClient(binding, new EndpointAddress(_configuration.GetSection("Services:Operaciones").Value));
        }

        public async Task<cierreOperacionesSistemaResponse> CierreOperacionesSistema(solicitudOperaciones request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.cierreOperacionesSistemaAsync(request);
        }

        public async Task<cierrePuntoVentaResponse> CierrePuntosVenta(solicitudCierrePuntoVenta request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.cierrePuntoVentaAsync(request);
        }

        public async Task<consultaEventoSignificativoResponse> ConsultaEventoSignificativo(solicitudConsultaEvento request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.consultaEventoSignificativoAsync(request);
        }

        public async Task<consultaPuntoVentaResponse> ConsultaPuntoVenta(solicitudConsultaPuntoVenta request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.consultaPuntoVentaAsync(request);
        }

        public async Task<registroEventoSignificativoResponse> RegistroEventoSignificativo(solicitudEventoSignificativo request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.registroEventoSignificativoAsync(request);
        }

        public async Task<registroPuntoVentaResponse> RegistroPuntosVenta(solicitudRegistroPuntoVenta request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.registroPuntoVentaAsync(request);
        }
    }
}
