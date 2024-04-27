using Entities.Models;
using Repositories.Contracts;

namespace Repositories.Concrete
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {

        }
    }
}
