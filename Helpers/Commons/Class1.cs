using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Helpers.Commons
{
    public static class LengthExtensionAttack
    {
        // Hàm tính giá trị băm MD5
        public static string MD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return ConvertHashToString(hashBytes);
            }
        }

        // Hàm tính giá trị băm SHA1
        public static string SHA1Hash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return ConvertHashToString(hashBytes);
            }
        }

        // Chuyển đổi byte array thành chuỗi hex
        private static string ConvertHashToString(byte[] hashBytes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        // Mô phỏng tấn công Length Extension Attack với MD5
        public static string SimulateLengthExtensionAttackMD5(string originalMessage, string dataToAppend)
        {
            // Băm thông điệp gốc
            string originalHash = MD5Hash(originalMessage);
            Console.WriteLine("Hash MD5 của thông điệp gốc: " + originalHash);

            // Thêm chuỗi mới vào thông điệp gốc
            string extendedMessage = originalMessage + dataToAppend;
            string newHash = MD5Hash(extendedMessage);

            return newHash;
        }

        // Mô phỏng tấn công Length Extension Attack với SHA1
        public static string SimulateLengthExtensionAttackSHA1(string originalMessage, string dataToAppend)
        {
            // Băm thông điệp gốc
            string originalHash = SHA1Hash(originalMessage);
            Console.WriteLine("Hash SHA1 của thông điệp gốc: " + originalHash);

            // Thêm chuỗi mới vào thông điệp gốc
            string extendedMessage = originalMessage + dataToAppend;
            string newHash = SHA1Hash(extendedMessage);

            return newHash;
        }

        //static void Main(string[] args)
        //{
        //    // Thông điệp ban đầu
        //    string originalMessage = "message";

        //    // Chuỗi kẻ tấn công muốn thêm vào
        //    string dataToAppend = "&data=newdata";

        //    // Mô phỏng Length Extension Attack với MD5
        //    string resultHashMD5 = SimulateLengthExtensionAttackMD5(originalMessage, dataToAppend);
        //    Console.WriteLine("Hash MD5 sau khi mở rộng chuỗi: " + resultHashMD5);

        //    // Mô phỏng Length Extension Attack với SHA1
        //    string resultHashSHA1 = SimulateLengthExtensionAttackSHA1(originalMessage, dataToAppend);
        //    Console.WriteLine("Hash SHA1 sau khi mở rộng chuỗi: " + resultHashSHA1);
        //}
    }

}
