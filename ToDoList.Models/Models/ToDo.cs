using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        [Required(ErrorMessage = "Please enter a category.")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;
        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage = "Please enter a status.")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;
        public bool Overdue => StatusId == "open" && DueDate >= DateTime.Today;
        public string? UserId { get; set; }
    }
}
