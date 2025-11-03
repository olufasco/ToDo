using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Pages.Todos;

public class CreateModel(ITodoService todoService) : PageModel
{
    [BindProperty]
    public Todo Todo { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        await todoService.AddAsync(Todo);
        return RedirectToPage("Index");
    }
}