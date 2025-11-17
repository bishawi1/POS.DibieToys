using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace POS.Teller
{
    public class Util
    {
        public static bool writeFile(string filePath, string jsonContent)
        {
            try
            {
                if(Path.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.WriteAllText(filePath, jsonContent);
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return false;
            }
        }
        public static string readFile(string filePath)
        {
            string jsonContent;
            try
            {
                //if (Path.Exists(filePath))
                //{
                //    File.Delete(filePath);
                //}
                jsonContent= File.ReadAllText(filePath,System.Text.Encoding.UTF8);
                return jsonContent;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return String.Empty;
            }
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }

    }
}
