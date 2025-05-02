namespace AACBackEnd.Helpers
{
    public static class StringHelper
    {
        public static byte[] HexStringToByteArray(this string hex)
        {
            if (string.IsNullOrEmpty(hex))
                return Array.Empty<byte>();

            if (hex.Length % 2 != 0)
                throw new ArgumentException("Invalid hex string length.");

            return Enumerable.Range(0, hex.Length / 2)
                             .Select(i => Convert.ToByte(hex.Substring(i * 2, 2), 16))
                             .ToArray();
        }
    }
}
