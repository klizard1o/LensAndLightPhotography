using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LensAndLight.Pages.Products;

public class EditModel : PageModel
{
    private readonly PhotographyContext _context;
    public EditModel(PhotographyContext context) { _context = context; }

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
        _context.Attach(Product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }
}