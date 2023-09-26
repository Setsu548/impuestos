using CreditoDebito;
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
    public class CreditoDebitoController : ControllerBase
    {
        #region Atributos
        private readonly IConfiguration _configuration;
        private readonly ICreditoDebitoManager _gestorFactura;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion

        public CreditoDebitoController(IConfiguration configuration,
                                     IHostingEnvironment environment)
        {
            _configuration = configuration;
            _hostingEnvironment = environment;
            _gestorFactura = new CreditoDebitoManager(_configuration, _hostingEnvironment);
        }

        #region Computarizada        
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("recepcion")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> Recepcion(CompDebitoCreditoRecepcionRequest request)
        {
            var resultado = await _gestorFactura.RecepcionFactura(request);
            return Ok(resultado);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("anulacion")]
        [HttpPost]
        public async Task<ActionResult<anulacionDocumentoAjusteResponse>> Anulacion(SolicitudAnulacion request)
        {
            var resultado = await _gestorFactura.AnulacionFactura(request);
            return Ok(resultado.RespuestaServicioFacturacion);
        }
        /// <summary>
        /// Realiza la recepción de una nota de Credito Debito
        /// </summary>
        /// <param name="request"></param>
        [Route("verificacion")]
        [HttpPost]
        public async Task<ActionResult<verificacionEstadoDocumentoAjusteResponse>> Verificacion(VerificacionEstado request)
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
        public async Task<IActionResult> VerificacionComunicacion(verificarComunicacion request)
        {
            var resultado = await _gestorFactura.VerificacionComunicacion(request);
            return Ok(resultado.@return);
        }
        #endregion
    }
}
