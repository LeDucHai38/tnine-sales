using tnine.Core.Shared.Infrastructure;

namespace tnine.Core.Shared.Repositories
{
    public interface ICategoryRepository : IRepository<Category, long>
    {
    }

    public class CategoryRepository : Repository<Category, long>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
