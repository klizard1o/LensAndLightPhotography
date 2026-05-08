using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LensAndLight;

namespace LensAndLight.Pages.Categories // The "Last Name" for this file
{
    public class DetailsModel : PageModel
    {
        private readonly PhotographyContext _context;
        public DetailsModel(PhotographyContext context) { _context = context; }

        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();
            Category = await _context.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(m => m.CategoryID == id);

            if (Category == null) return NotFound();
            return Page();
        }
    }
}