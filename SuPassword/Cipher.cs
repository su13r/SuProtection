using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SuPassword
{
    internal class Cipher
{
        public static string Encrypt(string key, string data)
        {
            string encData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                encData = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return encData;
        }

        public static string Decrypt(string key, string data)
        {
            string decData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                decData = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return decData;
        }

        private static byte[][] GetHashKeys(string key)
        {
            byte[][] result = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(key);
            byte[] rawIV = enc.GetBytes(key);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }

        private static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt =
                            new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }
        private static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt =
                            new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
        public static byte[] encrypt_aes256(byte[] unencrypted, byte[] key, byte[] salt)
        {
            byte[] encrypted = null;
            using (MemoryStream memory_stream = new MemoryStream())
            {
                using (RijndaelManaged aes256 = new RijndaelManaged())
                {
                    aes256.KeySize = 256; //64 chars equals aes256 key size
                    aes256.BlockSize = 128;//block = algorithm(256)/2
                    Rfc2898DeriveBytes rfc_key = new Rfc2898DeriveBytes(key, salt, 2000);
                    aes256.Key = rfc_key.GetBytes(aes256.KeySize / 8);
                    aes256.IV = rfc_key.GetBytes(aes256.BlockSize / 8);
                    aes256.Mode = CipherMode.CBC;//encrypts into blocks
                    using (CryptoStream crypto_stream = new CryptoStream(memory_stream, aes256.CreateEncryptor(), CryptoStreamMode.Write)) //creates the encryptor
                    {
                        crypto_stream.Write(unencrypted, 0, unencrypted.Length); //writes encrypted bytes to a memory stream
                        crypto_stream.Close();
                    }
                    encrypted = memory_stream.ToArray();
                }
            }
            return encrypted;
        }
        public static byte[] decrypt_aes256(byte[] encrypted, byte[] key, byte[] salt)
        {
            byte[] unencrypted = null;
            using (MemoryStream memory_stream = new MemoryStream())
            {
                using (RijndaelManaged aes256 = new RijndaelManaged())
                {
                    aes256.KeySize = 256; //64 chars equals aes256 key size
                    aes256.BlockSize = 128;//block = algorithm(256)/2
                    Rfc2898DeriveBytes rfc_key = new Rfc2898DeriveBytes(key, salt, 2000);
                    aes256.Key = rfc_key.GetBytes(aes256.KeySize / 8);
                    aes256.IV = rfc_key.GetBytes(aes256.BlockSize / 8);
                    aes256.Mode = CipherMode.CBC;//encrypts into blocks
                    using (CryptoStream crypto_stream = new CryptoStream(memory_stream, aes256.CreateDecryptor(), CryptoStreamMode.Write)) //creates the decryptor
                    {
                        crypto_stream.Write(encrypted, 0, encrypted.Length); //writes decrypted bytes to a memory stream
                        crypto_stream.Close();
                    }
                    unencrypted = memory_stream.ToArray();
                }
            }
            return unencrypted;
        }

        public static void file_encrypt(string file, string out_file, string key, string salt)
        {

            byte[] unencrypted = File.ReadAllBytes(file);
            //File.Delete(file);
            byte[] key_bytes = Encoding.UTF8.GetBytes(key);
            key_bytes = SHA256Managed.Create().ComputeHash(key_bytes);
            byte[] salt_bytes = Encoding.UTF8.GetBytes(salt);
            salt_bytes = SHA256Managed.Create().ComputeHash(salt_bytes);
            byte[] encrypted = encrypt_aes256(unencrypted, key_bytes, salt_bytes);
            File.WriteAllBytes(out_file, encrypted);
        }
        public static void file_decrypt(string file, string out_file, string key, string salt)
        {
            byte[] encrypted = File.ReadAllBytes(file);
            //File.Delete(file);
            byte[] key_bytes = Encoding.UTF8.GetBytes(key);
            key_bytes = SHA256Managed.Create().ComputeHash(key_bytes);
            byte[] salt_bytes = Encoding.UTF8.GetBytes(salt);
            salt_bytes = SHA256Managed.Create().ComputeHash(salt_bytes);
            byte[] decrypted = decrypt_aes256(encrypted, key_bytes, salt_bytes);
            File.WriteAllBytes(out_file, decrypted);
        }

    }
}
