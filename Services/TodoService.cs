namespace TodoAppBlazorServer.Services
{
    public class TodoService: ITodoServices
    {
        public readonly IList<TodoItem> _todoItems; //store data in memory

        public TodoService()
        {
            _todoItems = new List<TodoItem>() { 
                new TodoItem("Wash Clothes"),
                new TodoItem("Clean Desk")
            
            };
        }

        public void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public IEnumerable<TodoItem> GetAll() 
        { 
            return _todoItems.ToList();
        }

        public void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }



    }
}
