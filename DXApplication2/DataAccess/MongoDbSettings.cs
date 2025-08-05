#nullable enable
using System.Configuration;

namespace DXApplication2.DataAccess;

public class MongoDbSettings
{
    public static string? ConnectionString { get; } = ConfigurationManager.AppSettings["MongoDbConnectionString"];
    public static string? DatabaseName { get; } = ConfigurationManager.AppSettings["MongoDbDatabaseName"];
}