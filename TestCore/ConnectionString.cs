using System;
using System.Configuration;

namespace TestCore
{
    public class ConnectionString
    {
        public static string strCon = string.Empty;
        public static void loadConfig()
        {
            try
            {
                strCon = ConfigurationManager.ConnectionStrings["testConnection"].ConnectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
