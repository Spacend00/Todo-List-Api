using MediatR;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.UpdateToDoItem
{
    public class UpdateToDoItemCommand : IRequest<int>
    {
        public int ToDoItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime DeatLine { get; set; }
        public int CategoryId { get; set; }

    }
}
