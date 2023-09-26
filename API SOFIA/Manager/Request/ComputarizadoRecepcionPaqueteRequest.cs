using Computarizada;
using System.Collections.Generic;

namespace Manager.Request
{
    public class ComputarizadoRecepcionPaqueteRequest
    {
        public List<string> ListaFacturas { get; set; }
        public solicitudRecepcionPaquete solicitudRecepcion { get; set; }
    }
}
