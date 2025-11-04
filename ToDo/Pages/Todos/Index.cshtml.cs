using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Pages.Todos;

public class IndexModel : PageModel
{
    private readonly ITodoService _todoService;

    public IndexModel(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public List<Todo> Todos { get; private set; } = [];

    public async Task OnGetAsync()
    {
        Todos = await _todoService.GetAllAsync();
    }
}