namespace ToDoListApi.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<ToDoItem>? ToDoItems { get; set; }
    }
}
