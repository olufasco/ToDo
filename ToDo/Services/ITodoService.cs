using ToDo.Models;

namespace ToDo.Services;

public interface ITodoService
{
    Task<List<Todo>> GetAllAsync();
    Task<Todo?> GetByIdAsync(int id);
    Task AddAsync(Todo todo);
    Task UpdateAsync(Todo todo);
    Task DeleteAsync(int id);
    Task MarkCompletedAsync(int id);
}