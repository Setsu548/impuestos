using CompraVenta;
using Manager.Implementacion;
using Manager.Interface;
using Manager.Request;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Poco;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOFIA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraVentaController : ControllerBase
    {
        #region Atributos
        private readonly IConfiguration _configuration;
        private readonly ICompraVentaManager _gestorFactura;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion

        public CompraVentaController(IConfiguration configuration,
                                     IHostingEnvironment environment)
        {
            _configuration = configuration;
            _hostingEnvironment = environment;
            _gestorFactura = new CompraVentaManager(_configuration, _hostingEnvironment);
        }

        #region Computarizada

        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("recepcion")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> Recepcion(ComputarizadaRecepcionRequest request)
        {
            var resultado = await _gestorFactura.RecepcionFacturaComputarizada(request);
            return Ok(resultado);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("anulacion")]
        [HttpPost]
        public async Task<ActionResult<anulacionFacturaResponse>> Anulacion(SolicitudAnulacion request)
        {
            var resultado = await _gestorFactura.AnulacionFactura(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }

        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("masiva")]
        [HttpPost]
        public async Task<ActionResult<recepcionMasivaFacturaResponse>> RecepcionMasiva(CompraVentaRecepcionMasivaRequest request)
        {
            var resultado = await _gestorFactura.RecepcionMasiva(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("paquete")]
        [HttpPost]
        public async Task<ActionResult<recepcionPaqueteFacturaResponse>> RecepcionPaquete(CompraVentaRecepcionPaqueteRequest request)
        {
            var resultado = await _gestorFactura.RecepcionPaquete(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("validacionmasiva")]
        [HttpPost]
        public async Task<ActionResult<validacionRecepcionMasivaFacturaResponse>> ValidacionRecepcionMasiva(solicitudValidacionRecepcion request)
        {
            var resultado = await _gestorFactura.ValidacionRecepcionMasiva(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("validacionpaquete")]
        [HttpPost]
        public async Task<ActionResult<validacionRecepcionPaqueteFacturaResponse>> ValidacionRecepcionPaquete(solicitudValidacionRecepcion request)
        {
            var resultado = await _gestorFactura.ValidacionRecepcionPaquete(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("verificacion")]
        [HttpPost]
        public async Task<ActionResult<verificacionEstadoFacturaResponse>> Verificacion(VerificacionEstado request)
        {
            var resultado = await _gestorFactura.VerificacionEstado(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("comunicacion")]
        [HttpPost]
        public async Task<IActionResult> VerificacionComunicacion()
        {
            var resultado = await _gestorFactura.VerificacionComunicacion();
            return Ok(resultado.@return);
        }
        #endregion
    }
}