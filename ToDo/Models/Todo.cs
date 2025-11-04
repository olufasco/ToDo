using System.ComponentModel.DataAnnotations;
#nullable disable
namespace ToDo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;

    }
}
