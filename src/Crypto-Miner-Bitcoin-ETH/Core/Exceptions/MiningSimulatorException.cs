namespace CryptoMinerBitcoinETH.Core.Exceptions
{
    public class CryptoMinerBitcoinETHException : Exception
    {
        public CryptoMinerBitcoinETHException(string message) : base(message) { }
        public CryptoMinerBitcoinETHException(string message, Exception inner) : base(message, inner) { }
    }
}
