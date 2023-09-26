namespace Poco
{
    public class EnviarFacturaRequest
    {
        public string User { get; set; }
        public string Email { get; set; }
        public string FacturaXml { get; set; }
    }
}
