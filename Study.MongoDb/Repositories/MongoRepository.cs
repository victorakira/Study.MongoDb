using MongoDB.Driver;

namespace Study.MongoDb.Repositories;

public abstract class MongoRepository
{
    protected MongoRepository(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
        Database = client.GetDatabase(configuration.GetValue<string>("MongoDb:DatabaseName")!);
    }
    protected IMongoDatabase Database { get; private init; }
}
