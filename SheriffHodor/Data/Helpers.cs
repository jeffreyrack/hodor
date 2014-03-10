using System;
using System.Linq;
using System.Security.Cryptography;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public static class Helpers
    {
        public static byte[] StringToByteArray(string str)
        {
            var data = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, data, 0, data.Length);
            return data;
        }
        public static string ByteArrayToString(byte[] data)
        {
            char[] chars = new char[data.Length / sizeof(char)];
            System.Buffer.BlockCopy(data, 0, chars, 0, data.Length);
            return new string(chars);
        }
        public static bool Authenticate(User usr, string pwd)
        {
            var hash = new SHA1CryptoServiceProvider();
            return (hash.ComputeHash(StringToByteArray(pwd)).SequenceEqual(usr.Hash));
        }
    }
}
