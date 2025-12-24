using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItemById
{
    public class ToDoItemQueryById : IRequest<ResultItemDto>
    {
        public int ToDoItemId { get; set; }
    }
}
