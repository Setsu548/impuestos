using System.Xml.Serialization;

namespace Poco
{
    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
     // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("notaFiscalComputarizadaCreditoDebito", Namespace = "notaComputarizadaCreditoDebito.xsd")]
    public partial class notaFiscalComputarizadaCreditoDebito
    {

        private notaFiscalComputarizadaCreditoDebitoCabecera cabeceraField;

        private notaFiscalComputarizadaCreditoDebitoDetalle[] detalleField;

        /// <remarks/>
        public notaFiscalComputarizadaCreditoDebitoCabecera cabecera
        {
            get
            {
                return this.cabeceraField;
            }
            set
            {
                this.cabeceraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detalle")]
        public notaFiscalComputarizadaCreditoDebitoDetalle[] detalle
        {
            get
            {
                return this.detalleField;
            }
            set
            {
                this.detalleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class notaFiscalComputarizadaCreditoDebitoCabecera
    {

        private string nitEmisorField;

        private string razonSocialEmisorField;

        private string municipioField;

        private string telefonoField;

        private string numeroNotaCreditoDebitoField;

        private string cufField;

        private string cufdField;

        private string codigoSucursalField;

        private string direccionField;

        private string codigoPuntoVentaField;

        private System.DateTime fechaEmisionField;

        private string nombreRazonSocialField;

        private string codigoTipoDocumentoIdentidadField;

        private string numeroDocumentoField;

        private string complementoField;

        private string codigoClienteField;

        private string numeroFacturaField;

        private string numeroAutorizacionCufField;

        private System.DateTime fechaEmisionFacturaField;

        private decimal montoTotalOriginalField;

        private decimal montoTotalDevueltoField;

        private System.Nullable<decimal> montoDescuentoCreditoDebitoField;

        private decimal montoEfectivoCreditoDebitoField;

        private string codigoExcepcionField;

        private string leyendaField;

        private string usuarioField;

        private string codigoDocumentoSectorField;

        public notaFiscalComputarizadaCreditoDebitoCabecera()
        {
            this.codigoDocumentoSectorField = "24";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string nitEmisor
        {
            get
            {
                return this.nitEmisorField;
            }
            set
            {
                this.nitEmisorField = value;
            }
        }

        /// <remarks/>
        public string razonSocialEmisor
        {
            get
            {
                return this.razonSocialEmisorField;
            }
            set
            {
                this.razonSocialEmisorField = value;
            }
        }

        /// <remarks/>
        public string municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string telefono
        {
            get
            {
                return this.telefonoField;
            }
            set
            {
                this.telefonoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numeroNotaCreditoDebito
        {
            get
            {
                return this.numeroNotaCreditoDebitoField;
            }
            set
            {
                this.numeroNotaCreditoDebitoField = value;
            }
        }

        /// <remarks/>
        public string cuf
        {
            get
            {
                return this.cufField;
            }
            set
            {
                this.cufField = value;
            }
        }

        /// <remarks/>
        public string cufd
        {
            get
            {
                return this.cufdField;
            }
            set
            {
                this.cufdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codigoSucursal
        {
            get
            {
                return this.codigoSucursalField;
            }
            set
            {
                this.codigoSucursalField = value;
            }
        }

        /// <remarks/>
        public string direccion
        {
            get
            {
                return this.direccionField;
            }
            set
            {
                this.direccionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", IsNullable = true)]
        public string codigoPuntoVenta
        {
            get
            {
                return this.codigoPuntoVentaField;
            }
            set
            {
                this.codigoPuntoVentaField = value;
            }
        }

        /// <remarks/>
        public System.DateTime fechaEmision
        {
            get
            {
                return this.fechaEmisionField;
            }
            set
            {
                this.fechaEmisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string nombreRazonSocial
        {
            get
            {
                return this.nombreRazonSocialField;
            }
            set
            {
                this.nombreRazonSocialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codigoTipoDocumentoIdentidad
        {
            get
            {
                return this.codigoTipoDocumentoIdentidadField;
            }
            set
            {
                this.codigoTipoDocumentoIdentidadField = value;
            }
        }

        /// <remarks/>
        public string numeroDocumento
        {
            get
            {
                return this.numeroDocumentoField;
            }
            set
            {
                this.numeroDocumentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        public string codigoCliente
        {
            get
            {
                return this.codigoClienteField;
            }
            set
            {
                this.codigoClienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string numeroFactura
        {
            get
            {
                return this.numeroFacturaField;
            }
            set
            {
                this.numeroFacturaField = value;
            }
        }

        /// <remarks/>
        public string numeroAutorizacionCuf
        {
            get
            {
                return this.numeroAutorizacionCufField;
            }
            set
            {
                this.numeroAutorizacionCufField = value;
            }
        }

        /// <remarks/>
        public System.DateTime fechaEmisionFactura
        {
            get
            {
                return this.fechaEmisionFacturaField;
            }
            set
            {
                this.fechaEmisionFacturaField = value;
            }
        }

        /// <remarks/>
        public decimal montoTotalOriginal
        {
            get
            {
                return this.montoTotalOriginalField;
            }
            set
            {
                this.montoTotalOriginalField = value;
            }
        }

        /// <remarks/>
        public decimal montoTotalDevuelto
        {
            get
            {
                return this.montoTotalDevueltoField;
            }
            set
            {
                this.montoTotalDevueltoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> montoDescuentoCreditoDebito
        {
            get
            {
                return this.montoDescuentoCreditoDebitoField;
            }
            set
            {
                this.montoDescuentoCreditoDebitoField = value;
            }
        }

        /// <remarks/>
        public decimal montoEfectivoCreditoDebito
        {
            get
            {
                return this.montoEfectivoCreditoDebitoField;
            }
            set
            {
                this.montoEfectivoCreditoDebitoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", IsNullable = true)]
        public string codigoExcepcion
        {
            get
            {
                return this.codigoExcepcionField;
            }
            set
            {
                this.codigoExcepcionField = value;
            }
        }

        /// <remarks/>
        public string leyenda
        {
            get
            {
                return this.leyendaField;
            }
            set
            {
                this.leyendaField = value;
            }
        }

        /// <remarks/>
        public string usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codigoDocumentoSector
        {
            get
            {
                return this.codigoDocumentoSectorField;
            }
            set
            {
                this.codigoDocumentoSectorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class notaFiscalComputarizadaCreditoDebitoDetalle
    {

        private string actividadEconomicaField;

        private string codigoProductoSinField;

        private string codigoProductoField;

        private string descripcionField;

        private decimal cantidadField;

        private string unidadMedidaField;

        private decimal precioUnitarioField;

        private System.Nullable<decimal> montoDescuentoField;

        private decimal subTotalField;

        private string codigoDetalleTransaccionField;

        /// <remarks/>
        public string actividadEconomica
        {
            get
            {
                return this.actividadEconomicaField;
            }
            set
            {
                this.actividadEconomicaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codigoProductoSin
        {
            get
            {
                return this.codigoProductoSinField;
            }
            set
            {
                this.codigoProductoSinField = value;
            }
        }

        /// <remarks/>
        public string codigoProducto
        {
            get
            {
                return this.codigoProductoField;
            }
            set
            {
                this.codigoProductoField = value;
            }
        }

        /// <remarks/>
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }

        /// <remarks/>
        public decimal cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string unidadMedida
        {
            get
            {
                return this.unidadMedidaField;
            }
            set
            {
                this.unidadMedidaField = value;
            }
        }

        /// <remarks/>
        public decimal precioUnitario
        {
            get
            {
                return this.precioUnitarioField;
            }
            set
            {
                this.precioUnitarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> montoDescuento
        {
            get
            {
                return this.montoDescuentoField;
            }
            set
            {
                this.montoDescuentoField = value;
            }
        }

        /// <remarks/>
        public decimal subTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codigoDetalleTransaccion
        {
            get
            {
                return this.codigoDetalleTransaccionField;
            }
            set
            {
                this.codigoDetalleTransaccionField = value;
            }
        }
    }

}
