namespace StrategyDesignPattern
{
    public interface IFileCompressionMethod
    {
        public void Compress(string filename);

        public void DeCompress(string filename);
    }
}
