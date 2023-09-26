using Codigos;
using Manager.Implementacion;
using Manager.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOFIA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodigosController : ControllerBase
    {
        private readonly ICodigosManager _gestorCodigos;
        private readonly IConfiguration _configuration;

        public CodigosController(IConfiguration configuration,
                                            IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _gestorCodigos = new CodigosManager(_configuration);
        }

        /// <summary>
        /// Realiza la solicitud del cufd
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("solicitudcufd")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SolicitudCufd(Codigos.solicitudCufd request, string token)
        {
            var resultado = await _gestorCodigos.SolicitudCufd(request, token);
            return Ok(resultado.RespuestaCufd);
        }

        /// <summary>
        /// Realiza la solicitud del cufd masivamente
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("solicitudcufdmasivo")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SolicitudCufdMasivo(Codigos.solicitudCufdMasivo request, string token)
        {
            var resultado = await _gestorCodigos.SolicitudCufdMasivo(request, token);
            return Ok(resultado.RespuestaCufdMasivo);
        }

        /// <summary>
        /// Realiza la solicitud del cuis
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <param name="token">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("solicitudcuis")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SolicitudCuis(Codigos.solicitudCuis request, string token)
        {
            var resultado = await _gestorCodigos.SolicitudCuis(request, token);
            return Ok(resultado.RespuestaCuis);
        }

        /// <summary>
        /// Realiza la solicitud del cuis masivamente
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <param name="token">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("solicitudcuismasivo")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SolicitudCuisMasivo(Codigos.solicitudCuisMasivoSistemas request, string token)
        {
            var resultado = await _gestorCodigos.SolicitudCuisMasivo(request, token);
            return Ok(resultado.RespuestaCuisMasivo);
        }
       
        /// <summary>
        /// Verifica el NIT de un cliente
        /// </summary>
        /// <param name="request">Datos para la solicitud</param>
        /// <returns></returns>
        [Route("verificarNit")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> VerificarNitCliente(solicitudVerificarNit request, string token)
        {
            var resultado = await _gestorCodigos.VerificarNit(request, token);
            return Ok(resultado.RespuestaVerificarNit);
        }
    }
}