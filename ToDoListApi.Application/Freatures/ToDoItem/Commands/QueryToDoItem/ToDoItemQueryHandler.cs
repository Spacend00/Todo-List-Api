
using AutoMapper;
using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItem
{
    public class ToDoItemQueryHandler : IRequestHandler<ToDoItemQuery, List<ResultItemDto>>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public ToDoItemQueryHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }
        public async Task<List<ResultItemDto>> Handle(ToDoItemQuery request, CancellationToken cancellationToken)
        {
            var entity = await _toDoItemRepository.GetAllAsync();
            var mapList = _mapper.Map<List<ResultItemDto>>(entity);
            return mapList;
        }
    }
}
