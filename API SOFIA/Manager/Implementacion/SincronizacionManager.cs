using Manager.Interface;
using Microsoft.Extensions.Configuration;
using Sincronizacion;
using System.ServiceModel;
using System.Threading.Tasks;
using Utils;

namespace Manager.Implementacion
{
    public class SincronizacionManager : ISincronizacionManager
    {
        private readonly ServicioFacturacionSincronizacionClient client;

        public SincronizacionManager(IConfiguration configuration)
        {
            var binding = TokenConsumer.GenerateBinding();
            client = new ServicioFacturacionSincronizacionClient(binding, new EndpointAddress(configuration.GetSection("Services:Sincronizacion").Value));
        }

        public async Task<sincronizarListaLeyendasFacturaResponse> SincronizarListaLeyendasFactura(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarListaLeyendasFacturaAsync(request);
        }

        public async Task<sincronizarListaMensajesServiciosResponse> SincronizarListaMensajesServicios(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarListaMensajesServiciosAsync(request);
        }

        public async Task<sincronizarListaProductosServiciosResponse> SincronizarListaProductosServicios(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarListaProductosServiciosAsync(request);
        }

        public async Task<sincronizarParametricaEventosSignificativosResponse> SincronizarEventosSignificativos(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaEventosSignificativosAsync(request);
        }

        public async Task<sincronizarParametricaMotivoAnulacionResponse> SincronizarMotivoAnulacion(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaMotivoAnulacionAsync(request);
        }

        public async Task<sincronizarParametricaPaisOrigenResponse> SincronizarPaisOrigen(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaPaisOrigenAsync(request);
        }

        public async Task<sincronizarParametricaTipoDocumentoIdentidadResponse> SincronizarTipoDocumentoIdentidad(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoDocumentoIdentidadAsync(request);
        }

        public async Task<sincronizarParametricaTipoDocumentoSectorResponse> SincronizarTipoDocumentoSector(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoDocumentoSectorAsync(request);
        }

        public async Task<sincronizarParametricaTipoMonedaResponse> SincronizarTipoMoneda(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoMonedaAsync(request);
        }

        public async Task<sincronizarParametricaTipoEmisionResponse> SincronizarTipoEmision(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoEmisionAsync(request);
        }

        public async Task<sincronizarFechaHoraResponse> SincronizarHoraFecha(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarFechaHoraAsync(request);
        }

        public async Task<sincronizarParametricaTipoMetodoPagoResponse> SincronizarTipoMetodoPago(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoMetodoPagoAsync(request);
        }

        public async Task<sincronizarParametricaTipoPuntoVentaResponse> SincronizarTipoPuntoVenta(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoPuntoVentaAsync(request);
        }

        public async Task<sincronizarParametricaUnidadMedidaResponse> SincronizarTipoUnidadMedida(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaUnidadMedidaAsync(request);
        }

        public async Task<sincronizarActividadesResponse> SincronizarCodigosActividades(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarActividadesAsync(request);
        }

        public async Task<sincronizarListaActividadesDocumentoSectorResponse> SincronizarCodigosActividadesDocumentoSector(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarListaActividadesDocumentoSectorAsync(request);
        }

        public async Task<sincronizarParametricaTipoHabitacionResponse> SincronizarTipoHabitacion(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTipoHabitacionAsync(request);
        }

        public async Task<sincronizarParametricaTiposFacturaResponse> SincronizarTipoFactura(solicitudSincronizacion request, string token)
        {
            client.Endpoint.EndpointBehaviors.Add(new CustomAuthenticationBehaviour($"TokenApi {token}"));
            return await client.sincronizarParametricaTiposFacturaAsync(request);
        }
    }
}
