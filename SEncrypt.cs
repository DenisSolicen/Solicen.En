using System.Collections.Generic;
using System.IO;

namespace Solicen
{
    class SEncrypt
    {
        private static int KeyOffset = 120;
        private int GetRepeatKey(string s, int n)
        {
            var r = s;
            while(r.Length < n)
            {
                r += r;
            }
            return r.Substring(0, n).Length;
        }

        public static void Encrypt(string FileToEncrypt)
        {
            try
            {
                var file = File.ReadAllBytes(FileToEncrypt);
                List<byte> newByte = new List<byte>();
                foreach (var bytes in file)
                {
                    newByte.Add((byte)(bytes + KeyOffset));
                }
                File.Delete(FileToEncrypt);
                File.WriteAllBytes(FileToEncrypt, newByte.ToArray());
            }
            catch
            {

            }
        }

        public static void Decrypt(string FileToDecrypt)
        {
            try
            {
                var file = File.ReadAllBytes(FileToDecrypt);
                List<byte> newByte = new List<byte>();
                foreach (var bytes in file)
                {
                    newByte.Add((byte)(bytes - KeyOffset));
                }
                File.Delete(FileToDecrypt);
                File.WriteAllBytes(FileToDecrypt, newByte.ToArray());
            }
            catch
            {

            }
        }

        public static void DecryptWithOffset(string FileToDecrypt, int offset)
        {
            try
            {
                var file = File.ReadAllBytes(FileToDecrypt);
                List<byte> newByte = new List<byte>();
                foreach (var bytes in file)
                {
                    newByte.Add((byte)(bytes - offset));
                }
                File.Delete(FileToDecrypt);
                File.WriteAllBytes(FileToDecrypt, newByte.ToArray());
            }
            catch
            {

            }

        }

        public static string DecryptToStringWithOffset(string FileToDecrypt, int offset)
        {
            try
            {
                var file = File.ReadAllBytes(FileToDecrypt);
                List<byte> newByte = new List<byte>();
                foreach (var bytes in file)
                {
                    newByte.Add((byte)(bytes - offset));
                }
                return System.Text.Encoding.Default.GetString(newByte.ToArray());
            }
            catch
            {
                return null;
            }
      
        }
    }
}
