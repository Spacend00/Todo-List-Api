using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApi.Application.DTOs.Category;
using ToDoListApi.Application.Interfaces;

namespace ToDoListApi.Application.Freatures.Category.Commands.QueryCategory
{
    public class CategoryQueryHandler : IRequestHandler<CategoryQuery, List<ResultCategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper) 
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        
        public async Task<List<ResultCategoryDto>> Handle(CategoryQuery request, CancellationToken cancellationToken)
        {
            var entity = await _categoryRepository.GetAllAsync();
            var mappedList = _mapper.Map<List<ResultCategoryDto>>(entity);
            return mappedList;
        }
    }
}
