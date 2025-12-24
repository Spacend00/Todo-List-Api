using MediatR;
using ToDoListApi.Application.DTOs.Category;

namespace ToDoListApi.Application.Freatures.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<ResultCategoryDto>
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Or you can use (UpdateCategoryDto { get; set;})
    }
}
