using Sincronizacion;
using System.Threading.Tasks;

namespace Manager.Interface
{
    public interface ISincronizacionManager
    {
        public Task<sincronizarListaLeyendasFacturaResponse> SincronizarListaLeyendasFactura(solicitudSincronizacion request, string token);
        public Task<sincronizarListaMensajesServiciosResponse> SincronizarListaMensajesServicios(solicitudSincronizacion request, string token);
        public Task<sincronizarListaProductosServiciosResponse> SincronizarListaProductosServicios(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaEventosSignificativosResponse> SincronizarEventosSignificativos(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaMotivoAnulacionResponse> SincronizarMotivoAnulacion(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaPaisOrigenResponse> SincronizarPaisOrigen(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoDocumentoIdentidadResponse> SincronizarTipoDocumentoIdentidad(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoDocumentoSectorResponse> SincronizarTipoDocumentoSector(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoMonedaResponse> SincronizarTipoMoneda(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoEmisionResponse> SincronizarTipoEmision(solicitudSincronizacion request, string token);
        public Task<sincronizarFechaHoraResponse> SincronizarHoraFecha(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoMetodoPagoResponse> SincronizarTipoMetodoPago(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoPuntoVentaResponse> SincronizarTipoPuntoVenta(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaUnidadMedidaResponse> SincronizarTipoUnidadMedida(solicitudSincronizacion request, string token);
        public Task<sincronizarActividadesResponse> SincronizarCodigosActividades(solicitudSincronizacion request, string token);
        public Task<sincronizarListaActividadesDocumentoSectorResponse> SincronizarCodigosActividadesDocumentoSector(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTipoHabitacionResponse> SincronizarTipoHabitacion(solicitudSincronizacion request, string token);
        public Task<sincronizarParametricaTiposFacturaResponse> SincronizarTipoFactura(solicitudSincronizacion request, string token);
    }
}
