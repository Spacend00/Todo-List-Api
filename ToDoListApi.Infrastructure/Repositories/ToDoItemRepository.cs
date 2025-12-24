using ToDoListApi.Application.Interfaces;
using ToDoListApi.Domain.Entities;
using ToDoListApi.Infrastructure.Contexts;

namespace ToDoListApi.Infrastructure.Repositories
{
    public class ToDoItemRepository : GenericRepository<ToDoItem>, IToDoItemRepository
    {
        private readonly ToDoDbContext _context;
        public ToDoItemRepository(ToDoDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
