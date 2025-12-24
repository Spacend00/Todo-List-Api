using AutoMapper;
using MediatR;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.UpdateToDoItem
{
    public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateToDoItemCommand, int>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public UpdateTodoItemCommandHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = await _toDoItemRepository.GetByIdAsync(request.ToDoItemId);

            _mapper.Map(request, entity);
            await _toDoItemRepository.Update(entity);
            return entity.ToDoItemId;
        }
    }
}
