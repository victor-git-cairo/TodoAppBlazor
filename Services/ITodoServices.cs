namespace TodoAppBlazorServer.Services
{
    public interface ITodoServices
    {
        public void Add(TodoItem item);
        public IEnumerable<TodoItem>GetAll();
        public void Delete(TodoItem item);
    }
}
