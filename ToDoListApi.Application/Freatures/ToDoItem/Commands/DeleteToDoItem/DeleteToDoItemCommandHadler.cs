using MediatR;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.DeleteToDoItem
{
    public class DeleteToDoItemCommandHadler : IRequestHandler<DeleteToDoItemCommand, int>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        public DeleteToDoItemCommandHadler(IToDoItemRepository toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
        }
        public async Task<int> Handle(DeleteToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity =  await _toDoItemRepository.GetByIdAsync(request.ToDoItemId);
            await _toDoItemRepository.Delete(entity);
            return entity.ToDoItemId;
        }
    }
}
