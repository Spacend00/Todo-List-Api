
using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.QueryToDoItem
{
    public class ToDoItemQuery : IRequest<List<ResultItemDto>>
    {
    }
}
