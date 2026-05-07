using System.ComponentModel.DataAnnotations;

public class Product
{
    public int ProductID { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
    public decimal Price { get; set; }

    public string? ImageUrl { get; set; }

    [Required]
    public int CategoryID { get; set; } // Foreign Key
    
    public Category? Category { get; set; } // Navigation property
}