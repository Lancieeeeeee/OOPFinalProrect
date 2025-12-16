using System;
using System.Data.Common;

namespace OOPFinalProrect
{
   
    public static class DbConfig
    {
        // Default provider (change to desired provider at runtime)
        public static string ProviderName { get; set; } = "MySql.Data.MySqlClient";

        // Default connection strings; update to match your environment
        public static string MySqlConnectionString { get; set; } = "server=localhost;user=root;password=root;database=studentreg_db;";
        // Use LocalDB by default for SQL Server (developer-friendly). Change as needed.
        public static string SqlServerConnectionString { get; set; } = "Server=(localdb)\\MSSQLLocalDB;Database=studentreg_db;Trusted_Connection=True;";
        public static string SqliteConnectionString { get; set; } = "Data Source=studentreg.db";

        // Create a provider-agnostic DbConnection. Tries provider factory first then falls back to known types.
        public static DbConnection CreateConnection()
        {
            // Try provider factory (preferred)
            try
            {
                var factory = DbProviderFactories.GetFactory(ProviderName);
                var conn = factory.CreateConnection();
                if (conn == null) throw new InvalidOperationException($"Unable to create connection for provider {ProviderName}");

                if (ProviderName.IndexOf("MySql", StringComparison.OrdinalIgnoreCase) >= 0) conn.ConnectionString = MySqlConnectionString;
                else if (ProviderName.IndexOf("SqlClient", StringComparison.OrdinalIgnoreCase) >= 0 || ProviderName.IndexOf("SqlServer", StringComparison.OrdinalIgnoreCase) >= 0) conn.ConnectionString = SqlServerConnectionString;
                else if (ProviderName.IndexOf("Sqlite", StringComparison.OrdinalIgnoreCase) >= 0 || ProviderName.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) >= 0) conn.ConnectionString = SqliteConnectionString;
                else conn.ConnectionString = MySqlConnectionString;

                return conn;
            }
            catch
            {
                // Fallback: create known connection implementations using reflection
                DbConnection? conn = null;

                if (ProviderName.IndexOf("MySql", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var t = Type.GetType("MySql.Data.MySqlClient.MySqlConnection, MySql.Data")
                            ?? Type.GetType("MySqlConnector.MySqlConnection, MySqlConnector");
                    if (t != null) conn = Activator.CreateInstance(t) as DbConnection;
                    if (conn != null) conn.ConnectionString = MySqlConnectionString;
                }
                else if (ProviderName.IndexOf("Sqlite", StringComparison.OrdinalIgnoreCase) >= 0 || ProviderName.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var t = Type.GetType("Microsoft.Data.Sqlite.SqliteConnection, Microsoft.Data.Sqlite")
                            ?? Type.GetType("System.Data.SQLite.SQLiteConnection, System.Data.SQLite");
                    if (t != null) conn = Activator.CreateInstance(t) as DbConnection;
                    if (conn != null) conn.ConnectionString = SqliteConnectionString;
                }
                else if (ProviderName.IndexOf("SqlClient", StringComparison.OrdinalIgnoreCase) >= 0 || ProviderName.IndexOf("SqlServer", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var t = Type.GetType("Microsoft.Data.SqlClient.SqlConnection, Microsoft.Data.SqlClient")
                            ?? Type.GetType("System.Data.SqlClient.SqlConnection, System.Data.SqlClient");
                    if (t != null) conn = Activator.CreateInstance(t) as DbConnection;
                    if (conn != null) conn.ConnectionString = SqlServerConnectionString;
                }

                if (conn == null)
                    throw new InvalidOperationException($"Unable to create a DbConnection for provider '{ProviderName}'. Ensure the provider package is referenced.");

                return conn;
            }
        }

        // Static constructor attempts to register common provider factories so DbProviderFactories.GetFactory works
        // Also allow override via environment variables DB_PROVIDER and DB_CONN
        static DbConfig()
        {
            try
            {
                void TryRegister(string invariantName, string factoryTypeAssemblyQualified)
                {
                    try
                    {
                        var t = Type.GetType(factoryTypeAssemblyQualified);
                        if (t == null) return;

                        var instanceProp = t.GetProperty("Instance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                        if (instanceProp == null) return;

                        var factoryObj = instanceProp.GetValue(null) as DbProviderFactory;
                        if (factoryObj == null) return;

                        // Register only if not already present
                        try { var _ = DbProviderFactories.GetFactory(invariantName); }
                        catch { DbProviderFactories.RegisterFactory(invariantName, factoryObj); }
                    }
                    catch { }
                }

                TryRegister("Microsoft.Data.SqlClient", "Microsoft.Data.SqlClient.SqlClientFactory, Microsoft.Data.SqlClient");
                TryRegister("System.Data.SqlClient", "System.Data.SqlClient.SqlClientFactory, System.Data.SqlClient");
                TryRegister("MySql.Data.MySqlClient", "MySql.Data.MySqlClient.MySqlClientFactory, MySql.Data");
                TryRegister("MySqlConnector", "MySqlConnector.MySqlConnectorFactory, MySqlConnector");
                TryRegister("Microsoft.Data.Sqlite", "Microsoft.Data.Sqlite.SqliteFactory, Microsoft.Data.Sqlite");
                TryRegister("System.Data.SQLite", "System.Data.SQLite.SQLiteFactory, System.Data.SQLite");
            }
            catch { }

            // Allow runtime override via environment variables for easy testing
            try
            {
                var prov = Environment.GetEnvironmentVariable("DB_PROVIDER");
                var conn = Environment.GetEnvironmentVariable("DB_CONN");
                if (!string.IsNullOrWhiteSpace(prov)) ProviderName = prov;
                if (!string.IsNullOrWhiteSpace(conn))
                {
                    // assign to the matching connection string field
                    if (ProviderName.IndexOf("MySql", StringComparison.OrdinalIgnoreCase) >= 0) MySqlConnectionString = conn;
                    else if (ProviderName.IndexOf("Sqlite", StringComparison.OrdinalIgnoreCase) >= 0 || ProviderName.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) >= 0) SqliteConnectionString = conn;
                    else SqlServerConnectionString = conn;
                }
            }
            catch { }
        }

        // Helper for runtime configuration
        public static void Configure(string providerName, string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(providerName)) ProviderName = providerName;
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                if (ProviderName.IndexOf("MySql", StringComparison.OrdinalIgnoreCase) >= 0) MySqlConnectionString = connectionString;
                else if (ProviderName.IndexOf("Sqlite", StringComparison.OrdinalIgnoreCase) >= 0 || ProviderName.IndexOf("SQLite", StringComparison.OrdinalIgnoreCase) >= 0) SqliteConnectionString = connectionString;
                else SqlServerConnectionString = connectionString;
            }
        }
    }
}
