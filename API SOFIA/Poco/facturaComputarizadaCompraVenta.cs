using System.Xml.Serialization;

namespace Poco
{
    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("facturaComputarizadaCompraVenta", Namespace = "/compraVenta/facturaComputarizadaCompraVenta.xsd")]
    public partial class facturaComputarizadaCompraVenta
    {

        private facturaComputarizadaCompraVentaCabecera cabeceraField;

        private facturaComputarizadaCompraVentaDetalle[] detalleField;

        /// <remarks/>
        public facturaComputarizadaCompraVentaCabecera cabecera
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
        public facturaComputarizadaCompraVentaDetalle[] detalle
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class facturaComputarizadaCompraVentaCabecera
    {

        private long nitEmisorField;

        private string razonSocialEmisorField;

        private string municipioField;

        private string telefonoField;

        private int numeroFacturaField;

        private string cufField;

        private string cufdField;

        private int codigoSucursalField;

        private string direccionField;

        private int codigoPuntoVentaField;

        private System.DateTime fechaEmisionField;

        private string nombreRazonSocialField;

        private byte codigoTipoDocumentoIdentidadField;

        private string numeroDocumentoField;

        private string complementoField;

        private string codigoClienteField;

        private int codigoMetodoPagoField;

        private long? numeroTarjetaField;

        private decimal montoTotalField;

        private decimal montoTotalSujetoIvaField;

        private int codigoMonedaField;

        private int tipoCambioField;

        private decimal montoTotalMonedaField;

        private decimal montoGiftCardField;

        private decimal descuentoAdicionalField;

        private int codigoExcepcionField;

        private string? cafcField;

        private string leyendaField;

        private string usuarioField;

        private int codigoDocumentoSectorField;

        /// <remarks/>
        public long nitEmisor
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
        public int numeroFactura
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
        public int codigoSucursal
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
        public int codigoPuntoVenta
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
        public byte codigoTipoDocumentoIdentidad
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
        public int codigoMetodoPago
        {
            get
            {
                return this.codigoMetodoPagoField;
            }
            set
            {
                this.codigoMetodoPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public long? numeroTarjeta
        {
            get
            {
                return this.numeroTarjetaField;
            }
            set
            {
                this.numeroTarjetaField = value;
            }
        }

        /// <remarks/>
        public decimal montoTotal
        {
            get
            {
                return this.montoTotalField;
            }
            set
            {
                this.montoTotalField = value;
            }
        }

        /// <remarks/>
        public decimal montoTotalSujetoIva
        {
            get
            {
                return this.montoTotalSujetoIvaField;
            }
            set
            {
                this.montoTotalSujetoIvaField = value;
            }
        }

        /// <remarks/>
        public int codigoMoneda
        {
            get
            {
                return this.codigoMonedaField;
            }
            set
            {
                this.codigoMonedaField = value;
            }
        }

        /// <remarks/>
        public int tipoCambio
        {
            get
            {
                return this.tipoCambioField;
            }
            set
            {
                this.tipoCambioField = value;
            }
        }

        /// <remarks/>
        public decimal montoTotalMoneda
        {
            get
            {
                return this.montoTotalMonedaField;
            }
            set
            {
                this.montoTotalMonedaField = value;
            }
        }

        /// <remarks/>
        public decimal montoGiftCard
        {
            get
            {
                return this.montoGiftCardField;
            }
            set
            {
                this.montoGiftCardField = value;
            }
        }

        /// <remarks/>
        public decimal descuentoAdicional
        {
            get
            {
                return this.descuentoAdicionalField;
            }
            set
            {
                this.descuentoAdicionalField = value;
            }
        }

        /// <remarks/>
        public int codigoExcepcion
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string cafc
        {
            get
            {
                return this.cafcField;
            }
            set
            {
                this.cafcField = value;
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
        public int codigoDocumentoSector
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class facturaComputarizadaCompraVentaDetalle
    {

        private string actividadEconomicaField;

        private int codigoProductoSinField;

        private string codigoProductoField;

        private string descripcionField;

        private int cantidadField;

        private int unidadMedidaField;

        private decimal precioUnitarioField;

        private decimal? montoDescuentoField;

        private decimal subTotalField;

        private string numeroSerieField;

        private string numeroImeiField;

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
        public int codigoProductoSin
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
        public int cantidad
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
        public int unidadMedida
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
        public decimal? montoDescuento
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string numeroSerie
        {
            get
            {
                return this.numeroSerieField;
            }
            set
            {
                this.numeroSerieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string numeroImei
        {
            get
            {
                return this.numeroImeiField;
            }
            set
            {
                this.numeroImeiField = value;
            }
        }
    }
}