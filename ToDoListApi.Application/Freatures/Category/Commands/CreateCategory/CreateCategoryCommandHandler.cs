
using AutoMapper;
using MediatR;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.Category.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryEntity = _mapper.Map<Domain.Entities.Category>(request);
            await _categoryRepository.AddAsync(categoryEntity);
            return categoryEntity.CategoryId;
        }
    }
}
