using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;


namespace PUBG.Helper
{
    public class Crypto
    {
        
            public static string Hash(string password)
            {
                byte[] salt = new byte[] { 8, 6, 7, 6, 2, 3, 6 };

                // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA512,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));

                return hashed;
            }

            public static bool Verify(string password, string hashedPassword) => Hash(password) == hashedPassword;
        
    }
}
