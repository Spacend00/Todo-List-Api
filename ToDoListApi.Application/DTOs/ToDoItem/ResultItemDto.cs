namespace ToDoListApi.Application.DTOs.ToDoItem
{
    public class ResultItemDto
    {
        public int ToDoItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
