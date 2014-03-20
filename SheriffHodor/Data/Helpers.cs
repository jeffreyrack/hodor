using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Helper class for the Data namespace.
    /// </summary>
    internal static class Helpers
    {
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
        /// Check whenver the given user 'usr' can authenticate using the password 'pwd'.
        /// </summary>
        /// <param name="usr">User to authenticate.</param>
        /// <param name="pwd">Password for user.</param>
        /// <returns>True if the password match.</returns>
        internal static bool Authenticate(User usr, string pwd)
        {
            var hash = new SHA1CryptoServiceProvider();
            return (hash.ComputeHash(StringToByteArray(pwd)).SequenceEqual(usr.Hash));
        }

        internal static enum Difficulty {EASY, MEDIUM, HARD};

        internal static delegate Problem GenerateProblem(Difficulty diff);

        internal static Problem AddProblem(Difficulty diff)
        {
            //2-5 terms
            Random rand = new Random();
            int numOfTerms = rand.Next(2, 6);
            List<ushort> terms = new List<ushort>();
            int upperRange = 0;

            switch (diff)
            {
                case Difficulty.EASY: upperRange = 20;
                    break;
                case Difficulty.MEDIUM: upperRange = 100;
                    break;
                case Difficulty.HARD: upperRange = 1000;
                    break;
            }

            for (int i = 0; i < numOfTerms; i++)
            {
                terms.Add((ushort)rand.Next(0, upperRange + 1));
            }

            return(new Problem(terms, Problem.Operator.Addition));
        }

        internal static Problem SubProblem(Difficulty diff)
        {

            //2 terms
            Random rand = new Random();
            List<ushort> terms = new List<ushort>();
            int upperRange = 0;
            ushort term1;
            ushort term2;

            switch (diff)
            {
                case Difficulty.EASY: upperRange = 20;
                    break;
                case Difficulty.MEDIUM: upperRange = 100;
                    break;
                case Difficulty.HARD: upperRange = 1000;
                    break;
            }

            term1 = (ushort)rand.Next(0, upperRange + 1);
            term2 = (ushort)rand.Next(0, upperRange + 1);

            if (term1 > term2)
            {
                terms.Add(term1);
                terms.Add(term2);
            }
            else
            {
                terms.Add(term2);
                terms.Add(term1);
            }

            return (new Problem(terms, Problem.Operator.Substraction));
        }
    }
}
