using System.IO;
using System.Text;

namespace Utils
{
    public class ExtentedStringWriter : StringWriter
    {
        private readonly Encoding stringWriterEncoding;

        public ExtentedStringWriter(StringBuilder builder, Encoding desiredEncoding)
            : base()
        {
            this.stringWriterEncoding = desiredEncoding;
        }

        public override Encoding Encoding
        {
            get
            {
                return this.stringWriterEncoding;
            }
        }
    }
}
