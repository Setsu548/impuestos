using System;

namespace Poco
{
    public class CufRequest
    {
        public long Nit { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int CodigoSucursal { get; set; }
        public int TipoFactura { get; set; }
        public int NumeroFactura { get; set; }
        public int CodigoPuntoVenta { get; set; }
        public int CodigoModalidad { get; set; }
        public int CodigoEmision { get; set; }
        public int CodigoDocumentoSector { get; set; }
        public string CodigoControl { get; set; }
    }
}