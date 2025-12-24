
using MediatR;
using ToDoListApi.Application.DTOs.Category;

namespace ToDoListApi.Application.Freatures.Category.Commands.QueryCategoryById
{
    public class CategoryQueryById : IRequest<ResultCategoryDto>
    {
        public int CategoryId { get; set; }
    }
}
