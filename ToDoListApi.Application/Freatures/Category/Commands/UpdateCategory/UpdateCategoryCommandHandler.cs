using AutoMapper;
using MediatR;
using ToDoListApi.Application.DTOs.Category;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, ResultCategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<ResultCategoryDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _categoryRepository.GetByIdAsync(request.CategoryId);
            _mapper.Map(request, entity);
            await _categoryRepository.Update(entity);
            return _mapper.Map<ResultCategoryDto>(entity);
        }
    }
}
