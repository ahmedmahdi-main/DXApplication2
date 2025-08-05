using System.Threading.Channels;
using DevExpress.Utils.Frames;
using DXApplication2.Entities;
using MongoDB.Driver;

namespace DXApplication2.DataAccess;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext()
    {
        var settings = new MongoDbSettings();
        var client = new MongoClient(MongoDbSettings.ConnectionString);
        _database = client.GetDatabase(MongoDbSettings.DatabaseName);
    }

    public IMongoCollection<Item> ItemCollection => _database.GetCollection<Item>("Items");
    public IMongoCollection<Employee> EmployeesCollection => _database.GetCollection<Employee>("Employees");
    public IMongoCollection<ItemAssignment> ItemsAssignmentCollection => _database.GetCollection<ItemAssignment>(" ItemsAssignment");
    public IMongoCollection<User> UsersCollection => _database.GetCollection<User>("Users");
}