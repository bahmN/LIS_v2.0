using System;
using System.Security.Cryptography;
using System.Text;

namespace LIS.Adm
{
    class Hashing
    {
        public static string HashPassword(string plainText, byte[] salt)
        {
            int minSaltLength = 4, maxSaltLength = 16;

            byte[] saltBytes = null;
            if (salt != null) {
                saltBytes = salt;
            }
            else {
                Random r = new Random();
                int SaltLength = r.Next(minSaltLength, maxSaltLength);
                saltBytes = new byte[SaltLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
                rng.Dispose();
            }

            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(plainText);
            byte[] plainDataWithSalt = new byte[plainData.Length + saltBytes.Length];

            for (int x = 0; x < plainData.Length; x++)
                plainDataWithSalt[x] = plainData[x];
            for (int n = 0; n < saltBytes.Length; n++)
                plainDataWithSalt[plainData.Length + n] = saltBytes[n];

            byte[] hashValue = null;
            SHA512Managed sha512 = new SHA512Managed();
            hashValue = sha512.ComputeHash(plainDataWithSalt);
            sha512.Dispose();

            byte[] result = new byte[hashValue.Length + saltBytes.Length];
            for (int x = 0; x < hashValue.Length; x++)
                result[x] = hashValue[x];
            for (int n = 0; n < saltBytes.Length; n++)
                result[hashValue.Length + n] = saltBytes[n];

            return Convert.ToBase64String(result);
        }
    }
}
