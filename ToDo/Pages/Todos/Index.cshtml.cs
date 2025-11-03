using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Pages.Todos;

public class IndexModel(ITodoService todoService) : PageModel
{
    public List<Todo> Todos { get; private set; } = [];

    public async Task OnGetAsync()
    {
        Todos = await todoService.GetAllAsync();
    }
}
