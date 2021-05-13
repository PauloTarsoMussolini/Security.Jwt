using Microsoft.Extensions.DependencyInjection;

namespace NetDevPack.Security.JwtSigningCredentials.Tests.Warmups
{
    /// <summary>
    /// 
    /// </summary>
    public class WarmupDataProtectionStore : IWarmupTest
    {
        public WarmupDataProtectionStore()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            serviceCollection.AddMemoryCache();
            serviceCollection.AddDataProtection();
            serviceCollection.AddJwksManager().PersistKeysToDataProtection();

            Services = serviceCollection.BuildServiceProvider();
        }
        public ServiceProvider Services { get; set; }

    }
}