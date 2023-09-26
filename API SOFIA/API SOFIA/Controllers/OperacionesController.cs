using Manager.Implementacion;
using Manager.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Operaciones;
using Poco;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOFIA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        private readonly IOperacionesManager _gestorOperaciones;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public OperacionesController(IConfiguration configuration,
                                            IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _hostingEnvironment = environment;
            _gestorOperaciones = new OperacionesManager(_configuration);
        }

        /// <summary>
        /// Realiza el registro de un punto de venta
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("registropuntoventa")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> RegistroPuntoVenta(solicitudRegistroPuntoVenta request, string token)
        {
            var resultado = await _gestorOperaciones.RegistroPuntosVenta(request, token);
            return Ok(resultado.RespuestaRegistroPuntoVenta);
        }

        /// <summary>
        /// Realiza el cierre de operaciones del sistema
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("cierreSistema")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> CierreOperacionesSistema(solicitudOperaciones request, string token)
        {
            var resultado = await _gestorOperaciones.CierreOperacionesSistema(request, token);
            return Ok(resultado.RespuestaCierreSistemas);
        }

        /// <summary>
        /// Realiza la consulta de eventos significativos
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("consultaevento")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> ConsultaEventoSignificativo(solicitudConsultaEvento request, string token)
        {
            var resultado = await _gestorOperaciones.ConsultaEventoSignificativo(request, token);
            return Ok(resultado.RespuestaListaEventos);
        }

        /// <summary>
        /// Realiza la consulta de eventos significativos
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("consultapunto")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> ConsultaPuntoVenta(solicitudConsultaPuntoVenta request, string token)
        {
            var resultado = await _gestorOperaciones.ConsultaPuntoVenta(request, token);
            return Ok(resultado.RespuestaConsultaPuntoVenta);
        }

        /// <summary>
        /// Realiza el registro de un evento significativo
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("registroevento")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> RegistroEventoSignificativo(solicitudEventoSignificativo request, string token)
        {
            var resultado = await _gestorOperaciones.RegistroEventoSignificativo(request, token);
            return Ok(resultado.RespuestaListaEventos);
        }

        /// <summary>
        /// Realiza el cierre de un punto de venta
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("cierrepuntoventa")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> CierrePuntosVenta(solicitudCierrePuntoVenta request, string token)
        {
            var resultado = await _gestorOperaciones.CierrePuntosVenta(request, token);
            return Ok(resultado.RespuestaCierrePuntoVenta);
        }
    }
}