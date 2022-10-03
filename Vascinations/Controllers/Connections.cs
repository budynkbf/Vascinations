using System.Configuration;

namespace Vascinations.Controllers
{
    public static class Connection
    {
        public static string strConnection()
        {
            string aaa = ConfigurationManager.AppSettings.Get("TestMode");

            string ConnString = "";

            ConnString = $@"Data Source={ConfigurationManager.AppSettings.Get("DataSource")};Initial Catalog={ConfigurationManager.AppSettings.Get("InitialCatalog")};User Id={ConfigurationManager.AppSettings.Get("UserId")};Password={ConfigurationManager.AppSettings.Get("Password")};";
            return ConnString;
        }
    }
}