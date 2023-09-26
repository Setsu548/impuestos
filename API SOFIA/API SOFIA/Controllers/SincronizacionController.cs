using Manager.Implementacion;
using Manager.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Poco;
using Sincronizacion;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOFIA_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SincronizacionController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ISincronizacionManager _gestorSincronizacion;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public SincronizacionController(IConfiguration configuration,
                                            IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _hostingEnvironment = environment;
            _gestorSincronizacion = new SincronizacionManager(_configuration);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Leyendas
        /// </summary>
        /// <param name="request"></param>
        [Route("listaleyendas")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarListaLeyendasFactura(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarListaLeyendasFactura(request, token);
            return Ok(resultado.RespuestaListaParametricasLeyendas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Mensajes
        /// </summary>
        /// <param name="request"></param>
        [Route("listamensajes")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarListaMensajesServicios(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarListaMensajesServicios(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Productos y Servicios
        /// </summary>
        /// <param name="request"></param>
        [Route("listaproductosservicios")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarListaProductosServicios(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarListaProductosServicios(request, token);
            return Ok(resultado.RespuestaListaProductos);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Eventos Significativos
        /// </summary>
        /// <param name="request"></param>
        [Route("listaeventossignificativos")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarEventosSignificativos(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarEventosSignificativos(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de Motivos de anulación
        /// </summary>
        /// <param name="request"></param>
        [Route("motivoanulacion")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarMotivoAnulacion(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarMotivoAnulacion(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Paises de origen
        /// </summary>
        /// <param name="request"></param>
        [Route("paisorigen")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarPaisOrigen(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarPaisOrigen(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Documentos de Identidad
        /// </summary>
        /// <param name="request"></param>
        [Route("tipodocumentoidentidad")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoDocumentoIdentidad(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoDocumentoIdentidad(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Documentos por sector
        /// </summary>
        /// <param name="request"></param>
        [Route("tipodocumentosector")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoDocumentoSector(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoDocumentoSector(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Tipos de Emisión
        /// </summary>
        /// <param name="request"></param>
        [Route("tipoemision")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoEmision(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoEmision(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Lista de Tipos de Monedas
        /// </summary>
        /// <param name="request"></param>
        [Route("tipomoneda")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoMoneda(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoMoneda(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de la Hora y fecha
        /// </summary>
        /// <param name="request"></param>
        [Route("horafecha")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarHoraFecha(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarHoraFecha(request, token);
            return Ok(resultado.RespuestaFechaHora);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de puntos de venta
        /// </summary>
        /// <param name="request"></param>
        [Route("puntoventa")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarPuntoVenta(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoPuntoVenta(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de unidades de medida
        /// </summary>
        /// <param name="request"></param>
        [Route("unidadmedida")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarUnidadMedida(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoUnidadMedida(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de actividades
        /// </summary>
        /// <param name="request"></param>
        [Route("actividades")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarActividades(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarCodigosActividades(request, token);
            return Ok(resultado.RespuestaListaActividades);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de actividades y documento sector
        /// </summary>
        /// <param name="request"></param>
        [Route("actividadesdocumentosector")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarActividadesTipoDocumento(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarCodigosActividadesDocumentoSector(request, token);
            return Ok(resultado.RespuestaListaActividadesDocumentoSector);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de actividades
        /// </summary>
        /// <param name="request"></param>
        [Route("habitacion")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoHabitacion(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoHabitacion(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de actividades
        /// </summary>
        /// <param name="request"></param>
        [Route("metodopago")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoMetodoPago(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoMetodoPago(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }

        /// <summary>
        /// Realiza la sincronizacion de los tipos de actividades
        /// </summary>
        /// <param name="request"></param>
        [Route("tipofactura")]
        [HttpPost]
        public async Task<ActionResult<Resultado>> SincronizarTipoFactura(Sincronizacion.solicitudSincronizacion request, string token)
        {
            var resultado = await _gestorSincronizacion.SincronizarTipoFactura(request, token);
            return Ok(resultado.RespuestaListaParametricas);
        }
    }
}
