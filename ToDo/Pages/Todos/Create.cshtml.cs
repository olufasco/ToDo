using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Pages.Todos;

public class CreateModel : PageModel
{
    private readonly ITodoService _todoService;

    public CreateModel(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [BindProperty]
    public Todo Todo { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        await _todoService.AddAsync(Todo);
        return RedirectToPage("Index");
    }
}