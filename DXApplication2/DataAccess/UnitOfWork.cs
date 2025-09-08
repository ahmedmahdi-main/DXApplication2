using System;
using System.Configuration;
using System.Threading.Tasks;
using DXApplication2.Entities;
using DXApplication2.Repositories;
using MongoDB.Driver;

namespace DXApplication2.DataAccess;

public class UnitOfWork : IUnitOfWork
{
    public IRepository<User> UsersRepository { get; }
    public IRepository<Item> ItemsRepository { get; }
    public IRepository<Employee> EmployeesRepository { get; }
    public IRepository<ItemAssignment> ItemsAssignmentRepository { get; }

    private readonly IMongoDatabase _database;

    public UnitOfWork()
    {
        var connectionString = ConfigurationManager.AppSettings["MongoDbConnectionString"];
        var databaseName = ConfigurationManager.AppSettings["MongoDbDatabaseName"];

        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidOperationException("MongoDB connection string is not configured in app.config.");

        if (string.IsNullOrWhiteSpace(databaseName))
            throw new InvalidOperationException("MongoDB database name is not configured in app.config.");

        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);

        UsersRepository = new Repository<User>(_database, "Users");
        ItemsRepository = new Repository<Item>(_database, "Items");
        EmployeesRepository = new Repository<Employee>(_database, "Employees");
        ItemsAssignmentRepository = new Repository<ItemAssignment>(_database, "ItemsAssignment");

        EnsureIndexes(); // 👈 تنفذ هنا مرة واحدة
    }

    private void EnsureIndexes()
    {
        try
        {
            var employeesCollection = _database.GetCollection<Employee>("Employees");
            var indexOptions = new CreateIndexOptions { Unique = true };
            var indexDefinition = Builders<Employee>.IndexKeys.Ascending(e => e.NationalId);
            var indexModel = new CreateIndexModel<Employee>(indexDefinition, indexOptions);

            employeesCollection.Indexes.CreateOne(indexModel);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
           // throw;
        }
    }

    public async Task CommitAsync() => await Task.CompletedTask;

    public void Dispose() { }
}
