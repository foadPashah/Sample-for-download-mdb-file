using System.Configuration;


namespace DownloadAccessFileSample.Utilities
{
    public static class OledbConnectionString
    {
        public static string GetOledbConnection()
        {
            return ConfigurationManager.AppSettings["oledbConnection"];
        }
    }
}