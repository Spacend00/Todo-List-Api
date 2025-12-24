namespace ToDoListApi.Application.DTOs.ToDoItem
{
    public class CreateItemDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
