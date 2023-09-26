using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class GeneradorFacturaUtils
    {
        private readonly string pathXsdCompraVentaComputarizada;
        private readonly string pathXsdCreditoDebitoComputarizado;
        private readonly string pathXsdHospitalComputarizado;
        private readonly string pathXsdEducativoComputarizado;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;

        public GeneradorFacturaUtils(IConfiguration configuration, IHostingEnvironment environment)
        {
            _environment = environment;
            pathXsdCompraVentaComputarizada = _environment.WebRootPath + @"\Xsd\facturaComputarizadaCompraVenta.xsd";
            pathXsdCreditoDebitoComputarizado = _environment.WebRootPath + @"\Xsd\notaComputarizadaCreditoDebito.xsd";
            pathXsdHospitalComputarizado = _environment.WebRootPath + @"\Xsd\facturaComputarizadaHospitalClinica.xsd";
            pathXsdEducativoComputarizado = _environment.WebRootPath + @"\Xsd\facturaComputarizadaSectorEducativo.xsd";
        }

        public byte[] GenerarComputarizada(facturaComputarizadaCompraVenta factura, out string xmlOut)
        {
            xmlOut = string.Empty;
            var xmlGenerado = XmlUtils.SerializacionXmlString(typeof(facturaComputarizadaCompraVenta), factura);
            bool resultadoVerificacionEsquemaComp = XmlUtils.VerificacionEsquemaXSDString(xmlGenerado, pathXsdCompraVentaComputarizada, _environment);
            if (resultadoVerificacionEsquemaComp)
            {
                UTF8Encoding encoding = new UTF8Encoding();
                xmlOut = xmlGenerado;
                return CompresionUtils.Comprimir(encoding.GetBytes(xmlGenerado));
            }
            else
            {
                return null;
            }
        }

        public byte[] GenerarCreditoDebitoComputarizada(notaFiscalComputarizadaCreditoDebito factura, out string xmlOut)
        {
            xmlOut = string.Empty;
            var xmlGenerado = XmlUtils.SerializacionXmlString(typeof(notaFiscalComputarizadaCreditoDebito), factura);
            bool resultadoVerificacionEsquemaComp = XmlUtils.VerificacionEsquemaXSDString(xmlGenerado, pathXsdCreditoDebitoComputarizado, _environment);
            if (resultadoVerificacionEsquemaComp)
            {
                UTF8Encoding encoding = new UTF8Encoding();
                xmlOut = xmlGenerado;
                return CompresionUtils.Comprimir(encoding.GetBytes(xmlGenerado));
            }
            else
            {
                return null;
            }
        }

        public byte[] GenerarComputarizadaHospital(facturaComputarizadaHospitalClinica factura, out string xmlOut)
        {
            xmlOut = string.Empty;
            var xmlGenerado = XmlUtils.SerializacionXmlString(typeof(facturaComputarizadaHospitalClinica), factura);
            bool resultadoVerificacionEsquemaComp = XmlUtils.VerificacionEsquemaXSDString(xmlGenerado, pathXsdHospitalComputarizado, _environment);
            if (resultadoVerificacionEsquemaComp)
            {
                UTF8Encoding encoding = new UTF8Encoding();
                xmlOut = xmlGenerado;
                return CompresionUtils.Comprimir(encoding.GetBytes(xmlGenerado));
            }
            else
            {
                return null;
            }
        }

        public byte[] GenerarComputarizadaEducativa(facturaComputarizadaSectorEducativo factura, out string xmlOut)
        {
            xmlOut = string.Empty;
            var xmlGenerado = XmlUtils.SerializacionXmlString(typeof(facturaComputarizadaSectorEducativo), factura);
            bool resultadoVerificacionEsquemaComp = XmlUtils.VerificacionEsquemaXSDString(xmlGenerado, pathXsdEducativoComputarizado, _environment);
            if (resultadoVerificacionEsquemaComp)
            {
                UTF8Encoding encoding = new UTF8Encoding();
                xmlOut = xmlGenerado;
                return CompresionUtils.Comprimir(encoding.GetBytes(xmlGenerado));
            }
            else
            {
                return null;
            }
        }
    }
}
