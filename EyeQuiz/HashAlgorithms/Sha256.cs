using System;
using System.Security.Cryptography;
using System.Text;
using EyeQuiz.Interfaces;

namespace EyeQuiz.HashAlgorithms
{
    public class Sha256 : IHash
    {
        public string GetHash(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            var sb = new StringBuilder();
            foreach (byte x in hash)
            {
                sb.Append(String.Format("{0:x2}", x));
            }

            return sb.ToString();
        }
    }
}