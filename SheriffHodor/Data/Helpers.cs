using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Helper class for the Data namespace.
    /// </summary>
    internal static class Helpers
    {
        private static System.Reflection.PropertyInfo getPropInfoT(Type t, string name)
        {
            var prop = t.GetProperty(name);
            if (prop == null)
                throw new ArgumentOutOfRangeException("propName", "No property with that name was found.");
            return prop;
        }
        public static object GetPropValue(object src, string propName)
        {
            return getPropInfoT(src.GetType(), propName).GetValue(src, null);
        }

        /// <summary>
        /// Turns multiple backslash path into a single backslash.
        /// Eg:
        /// @"C:\\\\\\\\\\invalid\\path"
        /// is turned into
        /// @"C:\invalid\path"
        /// </summary>
        /// <param name="path">The path to sanitize.</param>
        /// <returns>A new string with a safe path.</returns>
        internal static string SanitizePath(string path)
        {
            return Regex.Replace(path, "[\\+]{2,}", "\\");
        }
        /// <summary>
        /// Turn a string into it's byte-array representation.
        /// Used for cryptographic purpose (SHA-1 hashes).
        /// </summary>
        /// <param name="str">Any string, but most likely the user's password.</param>
        /// <returns>A byte array holding the undecoded string.</returns>
        internal static byte[] StringToByteArray(string str)
        {
            var data = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, data, 0, data.Length);
            return data;
        }
        /// <summary>
        /// Turn a byte-array into a string.
        /// Used for cryptographic purpose (SHA-1 hashes).
        /// 
        /// Note: If the string is altered, decoding error and
        ///     undefined behaviour may happen. Be careful !
        /// </summary>
        /// <param name="data">A byte array holding a valid string representation.</param>
        /// <returns>The resulting string.</returns>
        internal static string ByteArrayToString(byte[] data)
        {
            char[] chars = new char[data.Length / sizeof(char)];
            System.Buffer.BlockCopy(data, 0, chars, 0, data.Length);
            return new string(chars);
        }

        /// <summary>
        /// Return a sha1 string representation of a string.
        /// </summary>
        /// <param name="str">The string to get the sha1 of.</param>
        /// <returns>An hexadecimal, uppercase representation of the hash.</returns>
        internal static string sha1Of(string str)
        {
            var hash = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(hash.ComputeHash(StringToByteArray(str)));
        }

        /// <summary>
        /// Check whenver the given user 'usr' can authenticate using the password 'pwd'.
        /// </summary>
        /// <param name="usr">User to authenticate.</param>
        /// <param name="pwd">Password for user.</param>
        /// <returns>True if the password match.</returns>
        internal static bool Authenticate(User usr, string pwd)
        {
            Contract.Assert(usr != null);
            Contract.Assert(pwd != null);
            Contract.Assert(usr.Hash != null, "The selected teacher doesn't have a password set: "
                + "Users.xml is probably compromized, please remove it to get the default, or fix it.");
            return string.Equals(sha1Of(pwd), usr.Hash);
        }
    }
}
