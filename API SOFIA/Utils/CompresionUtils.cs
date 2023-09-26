using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Utils
{
    public static class CompresionUtils
    {
        public static byte[] Comprimir(byte[] inBytes)
        {
            MemoryStream ContentsGzippedStream = new MemoryStream();
            Stream s = new GZipOutputStream(ContentsGzippedStream);
            s.Write(inBytes, 0, inBytes.Length);
            s.Flush();
            s.Close();
            return ContentsGzippedStream.ToArray();
        }

        public static byte[] ComprimirTar(List<string> listaFacturas)
        {
            using (var ContentsGzippedStream = new MemoryStream())
            {
                using (var tarCompressor = new TarOutputStream(ContentsGzippedStream, Encoding.UTF8))
                {
                    var index = 0;
                    foreach (var factura in listaFacturas)
                    {
                        TarEntry entry = TarEntry.CreateTarEntry("F" + index);
                        byte[] fileBytes = Encoding.UTF8.GetBytes(factura);
                        entry.Size = fileBytes.Length;
                        tarCompressor.PutNextEntry(entry);
                        tarCompressor.Write(fileBytes);
                        tarCompressor.CloseEntry();
                        index++;
                    }
                    tarCompressor.Close();
                    return Comprimir(ContentsGzippedStream.ToArray());
                }
            }
        }
    }
}
