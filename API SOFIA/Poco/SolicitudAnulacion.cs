using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poco
{
    public class SolicitudAnulacion
    {
        public int codigoAmbiente { get; set; }
        public int codigoPuntoVenta { get; set; }
        public bool codigoPuntoVentaSpecified { get; set; }
        public string codigoSistema { get; set; }
        public int codigoSucursal { get; set; }
        public long nit { get; set; }
        public int codigoDocumentoSector { get; set; }
        public int codigoEmision { get; set; }
        public int codigoModalidad { get; set; }
        public string cufd { get; set; }
        public string cuis { get; set; }
        public int tipoFacturaDocumento { get; set; }
        public int codigoMotivo { get; set; }
        public string cuf { get; set; }
    }
}
