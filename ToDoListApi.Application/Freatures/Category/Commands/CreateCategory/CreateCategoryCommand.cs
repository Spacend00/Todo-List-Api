
using MediatR;

namespace ToDoListApi.Application.Freatures.Category.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<int>
    {
        public string CategoryName { get; set; }
    }
}
