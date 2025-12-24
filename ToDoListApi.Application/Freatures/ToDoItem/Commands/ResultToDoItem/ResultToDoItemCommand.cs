using MediatR;
using ToDoListApi.Application.DTOs.ToDoItem;

namespace ToDoListApi.Application.Freatures.ToDoItem.Commands.ResultToDoItem
{
    public class ResultToDoItemCommand : IRequest<List<ResultItemDto>>
    {
    }
}
