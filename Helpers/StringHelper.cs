using System;
using System.Security.Cryptography;
using System.Text;

namespace apteryx.common.extend.Helpers
{
    public static class StringHelper
    {
        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static string ToMD5(this string s,Encoding encoding = null)
        {
            var ec = encoding ?? Encoding.ASCII;
            return BitConverter.ToString(MD5.Create().ComputeHash(ec.GetBytes(s))).Replace("-", "");
        }

        public static string ToSHA1(this string s, Encoding encoding = null)
        {
            var ec = encoding ?? Encoding.ASCII;
            return BitConverter.ToString(SHA1.Create().ComputeHash(ec.GetBytes(s))).Replace("-", "");
        }

        public static string ToSHA256(this string s, Encoding encoding = null)
        {
            var ec = encoding ?? Encoding.ASCII;
            return BitConverter.ToString(SHA256.Create().ComputeHash(ec.GetBytes(s))).Replace("-", "");
        }

        public static string ToSHA512(this string s, Encoding encoding = null)
        {
            var ec = encoding ?? Encoding.ASCII;
            return BitConverter.ToString(SHA512.Create().ComputeHash(ec.GetBytes(s))).Replace("-", "");
        }
    }
}
