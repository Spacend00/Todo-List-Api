using AutoMapper;
using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.ResultToDoItem
{
    public class ResultToDoItemCommandHandler : IRequestHandler<ResultToDoItemCommand, List<ResultItemDto>>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;
        public ResultToDoItemCommandHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }
        public async Task<List<ResultItemDto>> Handle(ResultToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = await _toDoItemRepository.GetAllAsync();
            var mapperList = _mapper.Map<List<ResultItemDto>>(entity);
            return mapperList;
        }
    }
}
