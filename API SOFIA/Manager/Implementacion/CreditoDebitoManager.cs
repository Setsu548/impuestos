using CreditoDebito;
using Manager.Interface;
using Manager.Request;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Poco;
using System;
using System.Threading.Tasks;
using Utils;

namespace Manager.Implementacion
{
    public class CreditoDebitoManager: ICreditoDebitoManager
    {
        private readonly IConfiguration _configuration;
        private GeneradorFacturaUtils generadorFacturas;
        private readonly ServicioFacturacionClient client;
        private readonly ComunUtils comunUtils;
        private IHostingEnvironment _environment;

        public CreditoDebitoManager(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
            client = new ServicioFacturacionClient();
            comunUtils = new ComunUtils();  
            generadorFacturas = new GeneradorFacturaUtils(_configuration, _environment);            
        }    
        public async Task<anulacionDocumentoAjusteResponse> AnulacionFactura(SolicitudAnulacion request)
        {
            return await client.anulacionDocumentoAjusteAsync(new solicitudAnulacion
            {
                codigoAmbiente = request.codigoAmbiente,
                codigoDocumentoSector = request.codigoDocumentoSector,
                codigoEmision = request.codigoEmision,
                codigoModalidad = request.codigoModalidad,
                codigoMotivo = request.codigoMotivo,
                codigoPuntoVenta = request.codigoPuntoVenta,
                codigoPuntoVentaSpecified = request.codigoPuntoVentaSpecified,
                codigoSistema = request.codigoSistema,
                codigoSucursal = request.codigoSucursal,
                cuf = request.cuf,
                cufd = request.cufd,
                cuis = request.cuis,
                nit = request.nit,
                tipoFacturaDocumento = request.tipoFacturaDocumento
            });
        }
        public async Task<Resultado> RecepcionFactura(CompDebitoCreditoRecepcionRequest request)
        {
            string xmlGenerado = string.Empty;

            var fechaActual = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            request.Factura.cabecera.fechaEmision = DateTime.Parse(fechaActual);
            request.Factura.cabecera.fechaEmisionFactura = DateTime.Parse(fechaActual);

            request.Factura.cabecera.cuf = comunUtils.GeneracionCUF(new CufRequest()
            {
                Nit = request.nit,
                FechaEnvio = DateTime.Parse(fechaActual),
                CodigoSucursal = request.codigoSucursal,
                TipoFactura = request.tipoFacturaDocumento,
                CodigoDocumentoSector = request.codigoDocumentoSector,
                CodigoEmision = request.codigoEmision,
                CodigoModalidad = request.codigoModalidad,
                CodigoPuntoVenta = request.codigoPuntoVenta,
                NumeroFactura = int.Parse(request.Factura.cabecera.numeroNotaCreditoDebito),
                CodigoControl = request.CodigoControl
            });
            request.archivo = generadorFacturas.GenerarCreditoDebitoComputarizada(request.Factura, out xmlGenerado);
            request.hashArchivo = CryptoUtils.EncriptarSha256(request.archivo);
            var result = await client.recepcionDocumentoAjusteAsync(new solicitudRecepcionFactura()
            {
                archivo = request.archivo,
                codigoAmbiente = request.codigoAmbiente,
                hashArchivo = request.hashArchivo,
                codigoDocumentoSector = request.codigoDocumentoSector,
                codigoEmision = request.codigoEmision,
                codigoModalidad = request.codigoModalidad,
                codigoPuntoVenta = request.codigoPuntoVenta,
                codigoPuntoVentaSpecified = request.codigoPuntoVentaSpecified,
                codigoSistema = request.codigoSistema,
                codigoSucursal = request.codigoSucursal,
                cufd = request.cufd,
                cuis = request.cuis,
                fechaEnvio = fechaActual,
                nit = request.nit,
                tipoFacturaDocumento = request.tipoFacturaDocumento
            });

            return RespuestaUtils.FormatResponse(result.RespuestaServicioFacturacion, request.Factura.cabecera.cuf, xmlGenerado, DateTime.Parse(request.fechaEnvio));
        }
        public Task<verificarComunicacionResponse> VerificacionComunicacion(verificarComunicacion request)
        {
            throw new System.NotImplementedException();
        }
        public Task<verificacionEstadoDocumentoAjusteResponse> VerificacionEstado(VerificacionEstado request)
        {
            return client.verificacionEstadoDocumentoAjusteAsync(new solicitudVerificacionEstado {
                codigoAmbiente = request.codigoAmbiente,
                codigoDocumentoSector = request.codigoDocumentoSector,
                codigoEmision = request.codigoEmision,
                codigoModalidad = request.codigoModalidad,
                codigoPuntoVenta = request.codigoPuntoVenta,
                codigoPuntoVentaSpecified = request.codigoPuntoVentaSpecified,
                codigoSistema = request.codigoSistema,
                codigoSucursal = request.codigoSucursal,
                cuf = request.cuf,
                cufd = request.cufd,
                cuis = request.cuis,
                nit = request.nit,
                tipoFacturaDocumento = request.tipoFacturaDocumento
            });
        }
    }
}
