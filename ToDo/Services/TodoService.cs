using Microsoft.EntityFrameworkCore;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Services;

public class TodoService(AppDbContext context) : ITodoService
{
    public async Task<List<Todo>> GetAllAsync() =>
        await context.Todos.ToListAsync();

    public async Task<Todo?> GetByIdAsync(int id) =>
        await context.Todos.FindAsync(id);

    public async Task AddAsync(Todo todo)
    {
        context.Todos.Add(todo);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Todo todo)
    {
        context.Todos.Update(todo);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var todo = await context.Todos.FindAsync(id);
        if (todo is not null)
        {
            context.Todos.Remove(todo);
            await context.SaveChangesAsync();
        }
    }

    public async Task MarkCompletedAsync(int id)
    {
        var todo = await context.Todos.FindAsync(id);
        if (todo is not null)
        {
            todo.IsCompleted = true;
            await context.SaveChangesAsync();
        }
    }
}