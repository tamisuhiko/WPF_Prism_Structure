using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Commons
{
    public static class SyncFuctionKeyGenerator
    {
        private static string privateKey = "SyNcFuSiOn@DevPlatForm";

        public static string GenerateBase64LicenseKey()
        {
            // Tạo chuỗi license không mã hóa
            string licenseData = "essentialstudio;26.0.0;9999-12-31;0000000000";

            // Mã hóa chuỗi bằng XOR với privateKey
            StringBuilder stringBuilder = new StringBuilder();
            int num = 0;
            for (int i = 0; i < licenseData.Length; i++)
            {
                if (num == privateKey.Length)
                {
                    num = 0;
                }
                int utf = char.ConvertToUtf32(licenseData, i) ^ char.ConvertToUtf32(privateKey, num);
                stringBuilder.Append(char.ConvertFromUtf32(utf));
                num++;
            }

            // Chuyển chuỗi mã hóa thành Base64
            byte[] bytes = Encoding.ASCII.GetBytes(stringBuilder.ToString());
            string base64Key = Convert.ToBase64String(bytes);

            return base64Key;
        }
    }
}
