using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.CraeteToDoItem
{
    public class CreateToDoItemCommand : IRequest<ResultItemDto>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsComleted { get; set; }
        public int CategoryId { get; set; }
    }
}
