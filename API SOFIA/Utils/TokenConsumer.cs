using System;
using System.ServiceModel;
using System.Xml;

namespace Utils
{
    public class TokenConsumer
    {
        private TokenConsumer() { }

        private static TokenConsumer _instance;

        public static TokenConsumer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TokenConsumer();
            }
            return _instance;
        }

        public static BasicHttpBinding GenerateBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                SendTimeout = TimeSpan.FromSeconds(1000),
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true,
                ReaderQuotas = XmlDictionaryReaderQuotas.Max
            };
            binding.Security.Mode = BasicHttpSecurityMode.Transport;

            return binding;
        }
    }
}
