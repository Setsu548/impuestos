namespace Poco
{
    public class Resultado
    {
        /// <summary>
        /// Bandera que define si la transacción es correcta.
        /// </summary>        
        public bool Correcto { get; set; }
        /// <summary>
        /// Notificación del proceso de transacción.
        /// </summary>
        public string Notificacion { get; set; }
        /// <summary>
        /// Tipo de notificación.
        /// </summary>
        public string TipoNotificacion { get; set; }
        /// <summary>
        /// Objeto que devuelve el resultado de la transacción.
        /// </summary>        
        public object DatoAdicional { get; set; }
        /// <summary>
        /// Define un código del resultado esperado.
        /// </summary>        
        public long CodigoResultado { get; set; }
    }
}
