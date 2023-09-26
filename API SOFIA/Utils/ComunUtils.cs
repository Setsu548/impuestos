using Poco;
using System;

namespace Utils
{
    public class ComunUtils
    {
        #region Métodos Públicos
        public string GeneracionCUF(CufRequest datosFactura)
        {
            string nitArreglado = CompletarLongitudes(datosFactura.Nit.ToString(), 13);
            string fechaHoraArreglada = CompletarLongitudes(datosFactura.FechaEnvio.ToString("yyyyMMddHHmmssfff"), 17);
            string sucursalArreglada = CompletarLongitudes(datosFactura.CodigoSucursal.ToString(), 4);
            string codigoDocumentoSectorArreglado = CompletarLongitudes(datosFactura.CodigoDocumentoSector.ToString(), 2);
            string nroFacturaArreglada = CompletarLongitudes(datosFactura.NumeroFactura.ToString(), 10);
            string puntoVentaArreglado = CompletarLongitudes(datosFactura.CodigoPuntoVenta.ToString(), 4);

            //Concatenar valores
            string valorConcatenado = nitArreglado +
                fechaHoraArreglada +
                sucursalArreglada +
                datosFactura.CodigoModalidad +
                datosFactura.CodigoEmision +
                datosFactura.TipoFactura +
                codigoDocumentoSectorArreglado +
                nroFacturaArreglada +
                puntoVentaArreglado;

            //Calcular el mod11
            var mod11 = CalcularDigitoMod11(valorConcatenado, 1, 9, false);
            //Concatenar el mod
            string valorConMod11 = valorConcatenado + mod11;
            //Convertir a HEX
            var convertidoHex = StringToHex7(valorConMod11);
            return convertidoHex + datosFactura.CodigoControl;
        }
        #endregion

        #region Métodos Privados
        private string CalcularDigitoMod11(string dato, int numDig, int limMult, bool x10)
        {
            int mult, soma, dig;
            if (!x10) numDig = 1;
            for (int n = 1; n <= numDig; n++)
            {
                soma = 0;
                mult = 2;
                for (int i = dato.Length - 1; i >= 0; i--)
                {
                    soma += (mult * int.Parse(dato.Substring(i, 1)));
                    if (++mult > limMult)
                        mult = 2;
                }
                if (x10)
                {
                    dig = ((soma * 10) % 11) % 10;
                }
                else
                {
                    dig = soma % 11;
                }
                if (x10)
                {
                    dig = ((soma * 10) % 11) % 10;
                }
                else
                {
                    dig = soma % 11;
                }
                if (dig == 10)
                {
                    dato += "1";
                }
                if (dig == 11)
                {
                    dato += "0";
                }
                if (dig < 10)
                {
                    dato += Convert.ToString(dig);
                }
            }
            return dato.Substring(dato.Length - numDig, 1);
        }
        private string StringToHex7(string hexstring)
        {
            string residuo = "";
            string strcociente = "";
            string valorHex = "";
            string nuevoCociente = "";

            do
            {
                int i = 0;
                while (i < hexstring.Length)
                {
                    int j = 0;
                    string cocienteextra = "";
                    do
                    {
                        strcociente = residuo + strcociente + hexstring.Substring(i, 1);
                        i++;
                        j++;
                        cocienteextra = (j >= 2 && i > 2) ? cocienteextra + "0" : cocienteextra;
                        residuo = (j >= 1 && i > 2) ? "" : residuo;
                    } while (Convert.ToInt32(strcociente) < 16 && i < hexstring.Length);

                    int residuo0 = Convert.ToInt32(strcociente) % 16;
                    int cociente0 = Convert.ToInt32(strcociente) / 16;
                    strcociente = "";
                    residuo = residuo0.ToString();
                    nuevoCociente = nuevoCociente.Length > 0 ? nuevoCociente + cocienteextra + cociente0.ToString() : cociente0.ToString();
                }
                valorHex = firstHex(Convert.ToInt32(residuo)) + valorHex;
                hexstring = nuevoCociente;
                nuevoCociente = "";
                residuo = "";

            } while (hexstring.Length > 2);

            int residuo1 = Convert.ToInt32(hexstring) % 16;
            int cociente1 = Convert.ToInt32(hexstring) / 16;
            valorHex = Convert.ToInt32(hexstring) < 16 ? firstHex(Convert.ToInt32(hexstring)) + valorHex : firstHex(cociente1) + firstHex(residuo1) + valorHex;

            return valorHex;
        }
        private string firstHex(int dec)
        {
            String numeroHex = "";
            switch (dec)
            {
                case 10:
                    numeroHex = "A";
                    break;
                case 11:
                    numeroHex = "B";
                    break;
                case 12:
                    numeroHex = "C";
                    break;
                case 13:
                    numeroHex = "D";
                    break;
                case 14:
                    numeroHex = "E";
                    break;
                case 15:
                    numeroHex = "F";
                    break;
                default:
                    numeroHex = dec.ToString();
                    break;
            }
            return numeroHex;
        }
        private string CompletarLongitudes(string datoCompletar, int longitud)
        {
            return datoCompletar.PadLeft(longitud, '0');
        }
        #endregion
    }
}
