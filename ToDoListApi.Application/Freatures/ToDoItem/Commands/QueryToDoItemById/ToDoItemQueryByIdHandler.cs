
using AutoMapper;
using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItemById
{
    public class ToDoItemQueryByIdHandler : IRequestHandler<ToDoItemQueryById, ResultItemDto>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;
        public ToDoItemQueryByIdHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }
        public async Task<ResultItemDto> Handle(ToDoItemQueryById request, CancellationToken cancellationToken)
        {
            var entity = await _toDoItemRepository.GetByIdAsync(request.ToDoItemId);
            return _mapper.Map<ResultItemDto>(entity);
        }
    }
}
