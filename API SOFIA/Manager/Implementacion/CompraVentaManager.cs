using CompraVenta;
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
    public class CompraVentaManager: ICompraVentaManager
    {
        private readonly ServicioFacturacionClient client;
        private GeneradorFacturaUtils generadorFacturas;
        private readonly ComunUtils comunUtils;
        private readonly IConfiguration _configuration;
        private IHostingEnvironment _environment;

        public CompraVentaManager(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
            client = new ServicioFacturacionClient();
            generadorFacturas = new GeneradorFacturaUtils(_configuration, _environment);
            comunUtils = new ComunUtils();            
        }

        public async Task<Resultado> RecepcionFacturaComputarizada(ComputarizadaRecepcionRequest request)
        {
            var xmlGenerada = string.Empty;
            var fechaActual = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");

            request.Factura.cabecera.fechaEmision = DateTime.Parse(fechaActual);
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
                NumeroFactura = request.Factura.cabecera.numeroFactura,
                CodigoControl = request.CodigoControl
            });
            request.archivo = generadorFacturas.GenerarComputarizada(request.Factura, out xmlGenerada);
            request.hashArchivo = CryptoUtils.EncriptarSha256(request.archivo);
            if (request.codigoEmision != 1)
            {
                return new Resultado() {
                    Correcto = true,
                    DatoAdicional = new { cuf = request.Factura.cabecera.cuf, xml = xmlGenerada }
                };
            }
            else
            {
                var result = await client.recepcionFacturaAsync(new solicitudRecepcionFactura()
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
                return RespuestaUtils.FormatResponse(result.RespuestaServicioFacturacion, request.Factura.cabecera.cuf, xmlGenerada, DateTime.Parse(request.fechaEnvio));
            }
        }

        public async Task<anulacionFacturaResponse> AnulacionFactura(SolicitudAnulacion request)
        {
            return await client.anulacionFacturaAsync(new solicitudAnulacion
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
            }) ;
        }

        public async Task<recepcionMasivaFacturaResponse> RecepcionMasiva(CompraVentaRecepcionMasivaRequest request)
        {
            var compresos = CompresionUtils.ComprimirTar(request.ListaFacturas);
            request.solicitudRecepcion.archivo = compresos;
            request.solicitudRecepcion.hashArchivo = CryptoUtils.EncriptarSha256(compresos);
            request.solicitudRecepcion.fechaEnvio = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            return await client.recepcionMasivaFacturaAsync(request.solicitudRecepcion);
        }

        public async Task<recepcionPaqueteFacturaResponse> RecepcionPaquete(CompraVentaRecepcionPaqueteRequest request)
        {
            var compresos = CompresionUtils.ComprimirTar(request.ListaFacturas);
            request.solicitudRecepcion.archivo = compresos;
            request.solicitudRecepcion.hashArchivo = CryptoUtils.EncriptarSha256(compresos);
            request.solicitudRecepcion.fechaEnvio = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            return await client.recepcionPaqueteFacturaAsync(request.solicitudRecepcion);
        }

        public async Task<validacionRecepcionMasivaFacturaResponse> ValidacionRecepcionMasiva(solicitudValidacionRecepcion request)
        {
            return await client.validacionRecepcionMasivaFacturaAsync(request);
        }

        public async Task<validacionRecepcionPaqueteFacturaResponse> ValidacionRecepcionPaquete(solicitudValidacionRecepcion request)
        {
            return await client.validacionRecepcionPaqueteFacturaAsync(request);
        }

        public async Task<verificarComunicacionResponse> VerificacionComunicacion()
        {
            return await client.verificarComunicacionAsync();
        }

        public async Task<verificacionEstadoFacturaResponse> VerificacionEstado(VerificacionEstado request)
        {
            return await client.verificacionEstadoFacturaAsync(new solicitudVerificacionEstado {
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
