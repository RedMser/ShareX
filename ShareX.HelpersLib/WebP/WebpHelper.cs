using System.Drawing;
using System.IO;

namespace ShareX.HelpersLib
{
    public static class WebpHelper
    {
        /// <param name="quality">Quality between 0 and 100. Use -1 to encode lossless WebP instead.</param>
        public static void SaveImageAsWebpStream(Image img, Stream stream, int quality = -1)
        {
            var wrapper = new WebpWrapper();
            if (quality < 0)
            {
                //Lossless encoding
                var data = wrapper.EncodeLossless((Bitmap)img);
                stream.Write(data, 0, data.Length);
            }
            else
            {
                //Lossy encoding
                if (quality > 100)
                    quality = 100;
                var data = wrapper.EncodeLossy((Bitmap)img, quality);
                stream.Write(data, 0, data.Length);
            }
        }
    }
}