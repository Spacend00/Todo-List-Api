using MediatR;
using ToDoListApi.Application.DTOs.Category;

namespace ToDoListApi.Application.Freatures.Category.Commands.QueryCategory
{
    public class CategoryQuery : IRequest<List<ResultCategoryDto>>
    {
    }
}
