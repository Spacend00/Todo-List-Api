
using ToDoListApi.Application.Interfaces;
using ToDoListApi.Domain.Entities;
using ToDoListApi.Infrastructure.Contexts;

namespace ToDoListApi.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ToDoDbContext _context;
        public CategoryRepository(ToDoDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
