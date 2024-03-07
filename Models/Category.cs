using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required")]
    [StringLength(60),MinLength(3, ErrorMessage = "Title must have between 3 and 60 characters")]
    public string Title { get; set; } = string.Empty;
}
