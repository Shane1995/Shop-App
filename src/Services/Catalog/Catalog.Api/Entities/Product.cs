namespace Catalog.Api.Entities
{
  using MongoDB.Bson;
  using MongoDB.Bson.Serialization.Attributes;

  public class Product
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    /// <summary>
    ///  Name of the product.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///  The category the product belongs too.
    /// </summary>
    public string Category { get; set; }

    /// <summary>
    ///  Short description about the product.
    /// </summary>
    public string Summary { get; set; }

    /// <summary>
    ///  A description about the product.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    ///  The path to the product's image.
    /// </summary>
    public string ImageFile { get; set; }

    /// <summary>
    ///  The cost/price of the product.
    /// </summary>
    public decimal Price { get; set; }
  }
}
