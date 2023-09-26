using Computarizada;
using Manager.Implementacion;
using Manager.Interface;
using Manager.Request;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Poco;
using System.Threading.Tasks;

namespace API_SOFIA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalClinicasController : ControllerBase
    {
        #region Atributos
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IHospitalesManager _gestorFactura;
        #endregion

        public HospitalClinicasController(IConfiguration configuration,
                                     IHostingEnvironment environment)
        {
            _configuration = configuration;
            _hostingEnvironment = environment;
            _gestorFactura = new HospitalesManager(_configuration, _hostingEnvironment);
        }

        #region Computarizada

        /// <summary>
        /// Realiza la recepción de una factura de hospital
        /// </summary>
        /// <param name="request"></param>
        [Route("recepcion")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> Recepcion(CompHospitalesRecepcionRequest request)
        {
            var resultado = await _gestorFactura.RecepcionFacturaComputarizada(request);
            return Ok(resultado);
        }
        /// <summary>
        /// Realiza la recepción de una factura de hospital
        /// </summary>
        /// <param name="request"></param>
        [Route("anulacion")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> Anulacion(SolicitudAnulacion request)
        {
            var resultado = await _gestorFactura.AnulacionFactura(request);
            return Ok(resultado);
        }

        /// <summary>
        /// Realiza la recepción de una factura de hospital
        /// </summary>
        /// <param name="request"></param>
        [Route("masiva")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> RecepcionMasiva(ComputarizadoRecepcionMasivaRequest request)
        {
            var resultado = await _gestorFactura.RecepcionMasiva(request);
            return Ok(resultado);
        }
        /// <summary>
        /// Realiza la recepción de una factura de hospital
        /// </summary>
        /// <param name="request"></param>
        [Route("paquete")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> RecepcionPaquete(ComputarizadoRecepcionPaqueteRequest request)
        {
            var resultado = await _gestorFactura.RecepcionPaquete(request);
            return Ok(resultado);
        }
        /// <summary>
        /// Realiza la recepción de una factura de hospital
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
        /// Realiza la recepción de una factura de hospital
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
        /// Realiza la recepción de una factura de hospital
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
        /// Realiza la recepción de una factura de hospital
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
