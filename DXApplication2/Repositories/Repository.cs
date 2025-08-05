using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DXApplication2.Services;
using MongoDB.Driver;

namespace DXApplication2.Repositories;

public class Repository<T>(IMongoDatabase database, string collectionName) : IRepository<T>
    where T : class
{
    private readonly IMongoCollection<T> _collection = database.GetCollection<T>(collectionName);
    private readonly SequenceService _sequenceService = new(database);

    public async Task<T> GetByIdAsync(string id)
    {
        return await _collection.Find(Builders<T>.Filter.Eq("_id", id)).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _collection.Find(predicate).ToListAsync();
    }

    public async Task AddAsync(T entity)

    {
        if (entity is IAutoIncrementEntity autoIncrementEntity)
        {
            autoIncrementEntity.Id = _sequenceService.GetNextSequenceValue(typeof(T).Name);
        }
        await _collection.InsertOneAsync(entity);
    }
    public async Task BulkSaveAsync(IEnumerable<T> entities)
    {
        var writes = new List<WriteModel<T>>();

        foreach (var entity in entities)
        {
            if (entity is IAutoIncrementEntity autoIncrementEntity && autoIncrementEntity.Id == 0)
            {
                autoIncrementEntity.Id = _sequenceService.GetNextSequenceValue(typeof(T).Name);
                writes.Add(new InsertOneModel<T>(entity));
            }
            else
            {
                var filter = Builders<T>.Filter.Eq("_id", (entity as IAutoIncrementEntity)!.Id);
                writes.Add(new ReplaceOneModel<T>(filter, entity) { IsUpsert = true });
            }
        }

        if (writes.Any())
        {
            await _collection.BulkWriteAsync(writes);
        }
    }

    public async Task UpdateAsync(string id, T entity)
    {
        await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), entity);
    }

    public async Task DeleteAsync(string id)
    {
        await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id));
    }

    public string GetNextId(T entity)
    {
        if (entity is IAutoIncrementEntity autoIncrementEntity)
        {
            return _sequenceService.GetNextSequenceValue(typeof(T).Name).ToString();
        }

        return "0";
    }

}
