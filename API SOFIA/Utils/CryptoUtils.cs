using System.Security.Cryptography;
using System.Text;

namespace Utils
{
    public static class CryptoUtils
    {
        public static string EncriptarSha256(byte[] datosEncriptados)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(datosEncriptados);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
