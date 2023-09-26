using Computarizada;
using System.Collections.Generic;

namespace Manager.Request
{
    public class ComputarizadoRecepcionMasivaRequest
    {
        public List<string> ListaFacturas { get; set; }
        public solicitudRecepcionMasiva solicitudRecepcion { get; set; }
    }
}
