using Codigos;
using Manager.Interface;
using Microsoft.Extensions.Configuration;
using System.ServiceModel;
using System.Threading.Tasks;
using Utils;

namespace Manager.Implementacion
{
    public class CodigosManager : ICodigosManager
    {
        private readonly ServicioFacturacionCodigosClient client;
        private readonly IConfiguration _configuration;

        public CodigosManager(IConfiguration configuration)
        {
            _configuration = configuration;
            var binding = TokenConsumer.GenerateBinding();
            client = new Codigos.ServicioFacturacionCodigosClient(binding, new EndpointAddress(configuration.GetSection("Services:Codigos").Value));
        }

        public async Task<cufdResponse> SolicitudCufd(solicitudCufd request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.cufdAsync(request);
        }

        public async Task<cufdMasivoResponse> SolicitudCufdMasivo(solicitudCufdMasivo request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.cufdMasivoAsync(request);
        }

        public async Task<cuisResponse> SolicitudCuis(solicitudCuis request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.cuisAsync(request);
        }

        public async Task<cuisMasivoResponse> SolicitudCuisMasivo(solicitudCuisMasivoSistemas request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.cuisMasivoAsync(request);
        }

        public async Task<verificarNitResponse> VerificarNit(solicitudVerificarNit request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.verificarNitAsync(request);
        }
    }
}
