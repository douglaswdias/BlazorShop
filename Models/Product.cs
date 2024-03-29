﻿using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required")]
    [StringLength(120), MinLength(3, ErrorMessage = "Title must have between 3 and 120 characaters")]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "Price is required")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
