namespace Catalog.Api.DataAccess.Context
{
  using Entities;
  using MongoDB.Driver;

  public interface ICatalogContext
  {
    IMongoCollection<Product> Products { get; }
  }
}