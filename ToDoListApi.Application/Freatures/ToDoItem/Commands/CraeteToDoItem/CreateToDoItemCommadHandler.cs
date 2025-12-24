using AutoMapper;
using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.CraeteToDoItem
{
    public class CreateToDoItemCommadHandler : IRequestHandler<CreateToDoItemCommand, ResultItemDto>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;
        public CreateToDoItemCommadHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }
        public async Task<ResultItemDto> Handle(CreateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Domain.Entities.ToDoItem>(request);
            entity.CreatedDate = DateTime.UtcNow;
            entity.IsCompleted = false;

            await _toDoItemRepository.AddAsync(entity);

            return _mapper.Map<ResultItemDto>(entity);
        }
    }
}
