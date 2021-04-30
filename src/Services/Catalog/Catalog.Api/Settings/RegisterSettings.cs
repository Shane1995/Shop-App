namespace Catalog.Api.Settings
{
  using Microsoft.Extensions.Configuration;
  using Microsoft.Extensions.DependencyInjection;

  public static class RegisterSettings
  {
    public static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration)
    {
      AddDatabaseSettings(services, configuration);
      return services;
    }

    private static void AddDatabaseSettings(IServiceCollection services, IConfiguration configuration)
    {
      services.Configure<DatabaseSettings>
        ((options) => configuration.GetSection("DatabaseSettings").Bind(options));
    }
  }
}