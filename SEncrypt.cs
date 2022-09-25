using System.Collections.Generic;
using System.IO;

namespace Solicen
{
    class SEncrypt
    {
        /// <summary>
        /// Конкретное смещение напрямую в файле
        /// </summary>
        private static int KeyOffset = 60;

        /// <summary>
        /// Возвращает повторяющийся ключ в строке
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int GetRepeatKey(string s, int n)
        {
            var r = s;
            while(r.Length < n)
            {
                r += r;
            }
            return r.Substring(0, n).Length;
        }

        /// <summary>
        /// Реализует зашифровку файла по пути файла
        /// </summary>
        /// <param name="FileToEncrypt">Путь до файла который нужно зашифровать</param>
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

        /// <summary>
        /// Реализует шифрование файла с конкретным смещением по пути файла
        /// </summary>
        /// <param name="FileToEncrypt">Файл который нужно зашифровать</param>
        /// <param name="offset">Смещение байтов</param>
        public static void EncryptWithOffset(string FileToEncrypt, int offset)
        {
            try
            {
                var file = File.ReadAllBytes(FileToEncrypt);
                List<byte> newByte = new List<byte>();
                foreach (var bytes in file)
                {
                    newByte.Add((byte)(bytes + offset));
                }
                File.Delete(FileToEncrypt);
                File.WriteAllBytes(FileToEncrypt, newByte.ToArray());
            }
            catch
            {

            }
        }

        /// <summary>
        /// Реализует расшифровку файла по пути файла
        /// </summary>
        /// <param name="FileToDecrypt">Путь до файла который нужно расшифровать</param>
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

        /// <summary>
        /// Реализует расшифровку файла по пути файла с конкретным смещением
        /// </summary>
        /// <param name="FileToDecrypt">Файл который нужно расшифровать</param>
        /// <param name="offset">Смещение байтов</param>
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

        /// <summary>
        /// Возвращает файл как расшифрованную строку, через конкретное смещение по пути файла
        /// </summary>
        /// <param name="FileToDecrypt">Файл который нужно расшифровать</param>
        /// <param name="offset">Смещение байтов</param>
        /// <returns></returns>
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
