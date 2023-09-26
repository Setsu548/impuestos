using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Utils
{
    public class XmlUtils
    {
        public static string SerializacionXmlString(Type claseFactura, object datosFactura)
        {
            try
            {
                using (var stringwriter = new ExtentedStringWriter(null, Encoding.UTF8))
                {
                    using (var xmlTextWriter = XmlWriter.Create(stringwriter, new XmlWriterSettings() { Indent = true }))
                    {
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                        ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                        xmlTextWriter.WriteStartDocument(true);
                        var serializer = new XmlSerializer(claseFactura);
                        serializer.Serialize(xmlTextWriter, datosFactura, ns);

                        var fixedXML = stringwriter.ToString();

                        return fixedXML.Replace("xmlns=", "xsi:noNamespaceSchemaLocation=");
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return string.Empty;
        }
        public static bool VerificacionEsquemaXSDString(string nombreArchivo, string rutaArchivoXSD, IHostingEnvironment environment)
        {
            XDocument xdoc = null;
            var settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Ignore;
            settings.ValidationType = ValidationType.Schema;

            try
            {
                xdoc = XDocument.Parse(nombreArchivo);
                var schemas = new XmlSchemaSet();
                schemas.Add(null, rutaArchivoXSD);
                using (var fs = File.OpenRead(environment.WebRootPath + @"\Xsd\xmldsig-core-schema.xsd"))
                using (var reader = XmlReader.Create(fs,
                new XmlReaderSettings()
                {
                    DtdProcessing = DtdProcessing.Ignore
                }))
                {
                    schemas.Add(@"http://www.w3.org/2000/09/xmldsig#", reader);
                }

                xdoc.Validate(schemas, null);

                return true;
            }
            catch (XmlSchemaValidationException ex)
            {
                if (ex.Message == "The 'http://www.w3.org/2000/09/xmldsig#:Signature' element is not declared.")
                {
                    return true;
                }
                Console.Write(ex);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            return false;
        }
    }
}
