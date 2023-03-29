using System;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;



namespace PasswordEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string password = ConfigurationManager.AppSettings["UserPassword"];

     
            byte[] encryptedPassword = EncryptStringToBytes_Aes(password);

            string filePath = "encrypted_password123.txt";
            File.WriteAllBytes(filePath, encryptedPassword);

            Console.WriteLine("Password encrypted and stored in file: " + filePath);
        }

        static byte[] EncryptStringToBytes_Aes(string plainText)
        {
          
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                          
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }
    }
}

