using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LensAndLight.Pages.Products;

public class DeleteModel : PageModel
{
    private readonly PhotographyContext _context;
    public DeleteModel(PhotographyContext context) { _context = context; }

    [BindProperty]
    public Product Product { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null) return NotFound();
        Product = await _context.Products.FindAsync(id);
        if (Product == null) return NotFound();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var product = await _context.Products.FindAsync(Product.ProductID);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage("./Index");
    }
}