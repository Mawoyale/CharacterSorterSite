using Microsoft.EntityFrameworkCore;
using CharacterSorterSite.Data;

namespace CharacterSorterSite.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDatabaseService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CharacterContext");

            if (connectionString == null)
            {
                throw new InvalidOperationException("Connection string 'CharacterContext' not found.");
            }

            services.AddDbContext<CharacterContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}