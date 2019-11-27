using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demo.Data;
using Volo.Abp.DependencyInjection;

namespace demo.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoredemoDbSchemaMigrator 
        : IdemoDbSchemaMigrator, ITransientDependency
    {
        private readonly demoMigrationsDbContext _dbContext;

        public EntityFrameworkCoredemoDbSchemaMigrator(demoMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}