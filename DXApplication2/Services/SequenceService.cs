using MongoDB.Bson;
using MongoDB.Driver;

namespace DXApplication2.Services;

public class SequenceService
{
    private readonly IMongoCollection<BsonDocument> _countersCollection;

    public SequenceService(IMongoDatabase database)
    {
        _countersCollection = database.GetCollection<BsonDocument>("Counters");
    }

    public int GetNextSequenceValue(string sequenceName)
    {
        var filter = Builders<BsonDocument>.Filter.Eq("_id", sequenceName);
        var update = Builders<BsonDocument>.Update.Inc("sequence_value", 1);
        var options = new FindOneAndUpdateOptions<BsonDocument>
        {
            ReturnDocument = ReturnDocument.After,
            IsUpsert = true // Create the document if it doesn't exist
        };

        var result = _countersCollection.FindOneAndUpdate(filter, update, options);
        return result["sequence_value"].AsInt32;
    }
}