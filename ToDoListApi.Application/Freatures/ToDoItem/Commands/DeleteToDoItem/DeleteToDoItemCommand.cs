using MediatR;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.DeleteToDoItem
{
    public class DeleteToDoItemCommand : IRequest<int>
    {
        public int ToDoItemId { get; set; }
    }
}
