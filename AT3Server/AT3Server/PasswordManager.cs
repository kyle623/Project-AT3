using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AT3Server
{
    class PasswordManager
    {
        static HashComputer m_hashComputer = new HashComputer();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plainTextPassword"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public string GeneratePasswordHash(string plainTextPassword, out string salt)
        {
            salt = SaltGenerator.GetSaltString();
            string saltedPassword = plainTextPassword + salt;
            string hashedPassword = m_hashComputer.GetPasswordHashAndSalt(saltedPassword);
            return hashedPassword + "," + salt;
        }

        /// <summary>
        /// check if the password matches
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public bool IsPasswordMatch(string password, string salt, string hash)
        {
            string finalString = password + salt;
            return hash == m_hashComputer.GetPasswordHashAndSalt(finalString);
        }
    }
}
