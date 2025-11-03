using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Pages.Todos
{
    public class DeleteModel(ITodoService todoService) : PageModel
    {
        [BindProperty]
        public Todo Todo { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var todo = await todoService.GetByIdAsync(id);
            if (todo is null) return NotFound();

            Todo = todo;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await todoService.DeleteAsync(Todo.Id);
            return RedirectToPage("Index");
        }
    }

}
