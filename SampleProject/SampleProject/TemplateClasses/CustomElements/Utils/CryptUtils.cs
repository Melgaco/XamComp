using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SampleProject.TemplateClasses
{
    public class CryptUtils
    {
        public static string MD5Hash(List<string> inputs)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            foreach(var inp in inputs)
            {
                byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(inp));
                for (int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString("x2"));
                }
            }
            return hash.ToString();
        }

        public static string SHA1Hash(List<string> inputs)
        {
            StringBuilder hash = new StringBuilder();
            SHA1 sha = new SHA1CryptoServiceProvider();
            foreach(var inp in inputs)
            {
                byte[] bytes = sha.ComputeHash(new UTF8Encoding().GetBytes(inp));
                for(int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString());
                }
            }
            return hash.ToString();
        }

        private bool ValidateMD5HashData(List<string> inputData, string storedHashData)
        {
            //hash input text and save it string variable
            string getHashInputData = MD5Hash(inputData);

            if (string.Compare(getHashInputData, storedHashData) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateSHA1HashData(List<string> inputData, string storedHashData)
        {
            //hash input text and save it string variable
            string getHashInputData = SHA1Hash(inputData);

            if (string.Compare(getHashInputData, storedHashData) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
