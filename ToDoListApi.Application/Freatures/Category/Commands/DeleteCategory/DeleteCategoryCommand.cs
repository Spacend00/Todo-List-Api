using MediatR;

namespace ToDoListApi.Application.Freatures.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest<int>
    {
        public int CategoryId { get; set; }
    }
}
