namespace Catalog.Api.DataAccess.Context
{
  using Entities;
  using Microsoft.Extensions.Options;
  using MongoDB.Driver;
  using Settings;

  public class CatalogContext : ICatalogContext
  {
    private readonly DatabaseSettings _settings;

    public CatalogContext(IOptions<DatabaseSettings> settings)
    {
      _settings = settings.Value;
      var client = new MongoClient(_settings.ConnectionString);
      IMongoDatabase database = client.GetDatabase(_settings.DatabaseName);
      Products = database.GetCollection<Product>(_settings.CollectionName);
    }

    public IMongoCollection<Product> Products { get; }

  }
}
