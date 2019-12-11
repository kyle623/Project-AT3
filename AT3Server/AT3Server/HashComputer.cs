using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AT3Server
{
    class HashComputer
    {
        /// <summary>
        /// get password hash and salt of the message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string GetPasswordHashAndSalt(string message)
        {
            // Let us use SHA256 algorithm to
            // generate the hash from this salted password
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] dataBytes = Utility.GetBytes(message);
            byte[] resultBytes = sha.ComputeHash(dataBytes);
            // return the hash string to the caller
            return Utility.GetString(resultBytes);
        }
    }
}
