using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LensAndLight;

namespace LensAndLight.Pages.Products // The "Last Name" for this file
{
    public class DetailsModel : PageModel
    {
        private readonly PhotographyContext _context;
        public DetailsModel(PhotographyContext context) { _context = context; }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();
            Product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);

            if (Product == null) return NotFound();
            return Page();
        }
    }
}