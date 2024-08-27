using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class TarCompression : IFileCompressionMethod
    {
        void IFileCompressionMethod.Compress(string filename)
        {
            Console.WriteLine($"{filename} compressed using Tar Compression");
        }

        void IFileCompressionMethod.DeCompress(string filename)
        {
            Console.WriteLine($"{filename} decompressed using TarCompression")
        }
    }
}
