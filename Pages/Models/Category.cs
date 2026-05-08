using System.ComponentModel.DataAnnotations;

public class Category
{
    public int CategoryID { get; set; }
    
    [Required, StringLength(50)]
    public string Name { get; set; } = string.Empty;
    
    public string? Description { get; set; }
    
   
    public ICollection<Product> Products { get; set; } = new List<Product>();
}