using AutoMapper;
using MediatR;
using System;
using ToDoListApi.Application.DTOs.Category;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.Category.Commands.QueryCategoryById
{
    public class CategoryQueryByIdHandler : IRequestHandler<CategoryQueryById, ResultCategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryQueryByIdHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<ResultCategoryDto> Handle(CategoryQueryById request, CancellationToken cancellationToken)
        {
            var entity = await _categoryRepository.GetByIdAsync(request.CategoryId);
            return _mapper.Map<ResultCategoryDto>(entity);
        }
    }
}
