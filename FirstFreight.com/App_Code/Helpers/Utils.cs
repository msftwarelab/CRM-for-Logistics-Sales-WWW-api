using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.Globalization;

namespace Helpers
{
    public class Utils
    {
        public static string GetDisplayDate(DateTime? dt)
        {
            try
            {
                return dt.HasValue ? dt.Value.ToString("dd MMM, yyyy HH:mm") : "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string ChangeQsValue(string currentPageUrl, string paramToReplace, string newValue)
        {
            string urlWithoutQuery = currentPageUrl.IndexOf('?') >= 0
                ? currentPageUrl.Substring(0, currentPageUrl.IndexOf('?'))
                : currentPageUrl;

            string queryString = currentPageUrl.IndexOf('?') >= 0
                ? currentPageUrl.Substring(currentPageUrl.IndexOf('?'))
                : null;

            var queryParamList = queryString != null
                ? HttpUtility.ParseQueryString(queryString)
                : HttpUtility.ParseQueryString(string.Empty);

            if (queryParamList[paramToReplace] != null)
            {
                queryParamList[paramToReplace] = newValue;
            }
            else
            {
                queryParamList.Add(paramToReplace, newValue);
            }
            return String.Format("{0}?{1}", urlWithoutQuery, queryParamList);
        }

        public static String Base64StringToHexString(String base64String)
        {
            var bytes = Convert.FromBase64String(base64String);
            var sbHexString = new StringBuilder();
            for (var i = 0; i < bytes.Length; i++)
            {
                sbHexString.Append(bytes[i].ToString("X2"));
            }
            return sbHexString.ToString();
        }

        public static string GetElapsedTime(DateTime? startTime, DateTime? endTime)
        {
            var elapsedTime = "00:00:00";
            if (endTime != null && startTime != null)
            {
                var span = endTime.Value.Subtract(startTime.Value);
                var hours = PadString(Convert.ToString(span.Hours), 2, "0");
                var minutes = PadString(Convert.ToString(span.Minutes), 2, "0");
                var seconds = PadString(Convert.ToString(span.Seconds), 2, "0");
                elapsedTime = hours + ":" + minutes + ":" + seconds;
            }
            return elapsedTime;
        }

        public static string PadString(string textIn, int length, string padChar)
        {
            // Pad string number with zeros
            var textOut = "";
            for (var i = 1; i <= length; i++)
            {
                if (textIn.Length < length)
                {
                    textOut = padChar + textIn;
                }
                else
                {
                    textOut = textIn;
                }
            }
            return textOut;
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        // Salt for Decryption / Encryption
        private static readonly byte[] KEY_64 = { 42, 16, 93, 156, 78, 4, 218, 32 };

        // Salt for Decryption / Encryption
        private static readonly byte[] IV_64 = { 55, 103, 246, 79, 36, 99, 167, 3 };

        public static string Decrypt(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                // Convert from string to byte array
                byte[] buffer = Convert.FromBase64String(value);
                MemoryStream ms = new MemoryStream(buffer);
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(KEY_64, IV_64), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            else
            {
                return "";
            }
        }

        public static string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
            return "";
        }

        public static bool IsNumeric(object expression)
        {
            if (expression == null)
                return false;

            double testDouble;
            if (expression is string)
            {
                CultureInfo provider;
                if (((string)expression).StartsWith("$"))
                    provider = new CultureInfo("en-US");
                else
                    provider = CultureInfo.InvariantCulture;

                if (double.TryParse((string)expression, NumberStyles.Any, provider, out testDouble))
                    return true;
            }
            else
            {
                if (double.TryParse(expression.ToString(), out testDouble))
                    return true;
            }

            //VB's 'IsNumeric' returns true for any boolean value:
            bool testBool;
            if (bool.TryParse(expression.ToString(), out testBool))
                return true;
            return false;
        }

    }
}
