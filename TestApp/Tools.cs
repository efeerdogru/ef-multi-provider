using System.Configuration;

namespace TestApp
{
    internal static class Tools
    {
        private static DbProviders _dbProvider;

        public static DbProviders DbProvider
        {
            get
            {
                if (_dbProvider != DbProviders.None)
                    return _dbProvider;

                switch (ConfigurationManager.ConnectionStrings["TestConnectionString"].ProviderName)
                {
                    case "System.Data.SqlClient":
                        _dbProvider = DbProviders.MsSql;
                        break;
                    case "Oracle.ManagedDataAccess.Client":
                        _dbProvider = DbProviders.Oracle;
                        break;
                    case "Npgsql":
                        _dbProvider = DbProviders.PostgreSql;
                        break;
                }

                return _dbProvider;
            }
        }
    }
}