using System;
using DXApplication2.DataAccess;
using MongoDB.Bson;
using MongoDB.Driver;


namespace DXApplication2.Services;

public static class MongoConnectionTester
{
    public static bool TestConnection(MongoDbSettings mongoDbSettings, out string errorMessage)
    {
        errorMessage = string.Empty;

        try
        {
            var client = new MongoClient(MongoDbSettings.ConnectionString);
            var database = client.GetDatabase(MongoDbSettings.DatabaseName);

            // أمر "ping" لاختبار الاتصال
            var command = new BsonDocument("ping", 1);
            var result = database.RunCommand<BsonDocument>(command);

            return true;
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
            return false;
        }
    }
}