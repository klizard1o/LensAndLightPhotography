using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LensAndLight; // Adjust this to match your namespace

public class IndexModel : PageModel
{
    private readonly PhotographyContext _context;

    public IndexModel(PhotographyContext context)
    {
        _context = context;
    }

    public PaginatedList<Product> Products { get; set; } = default!;

    // Properties for Search and Sort
    public string CurrentFilter { get; set; }
    public string CurrentSort { get; set; }
    public string NameSort { get; set; }
    public string PriceSort { get; set; }

    public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex)
    {
        CurrentSort = sortOrder;
        // Toggle sorting strings
        NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        PriceSort = sortOrder == "Price" ? "price_desc" : "Price";
        
        CurrentFilter = searchString;

        IQueryable<Product> productIQ = _context.Products.Include(p => p.Category);

        // 1. Searching Logic
        if (!String.IsNullOrEmpty(searchString))
        {
            productIQ = productIQ.Where(s => s.Title.Contains(searchString));
        }

        // 2. Sorting Logic
        productIQ = sortOrder switch
        {
            "name_desc" => productIQ.OrderByDescending(s => s.Title),
            "Price" => productIQ.OrderBy(s => s.Price),
            "price_desc" => productIQ.OrderByDescending(s => s.Price),
            _ => productIQ.OrderBy(s => s.Title),
        };

        // 3. Paging Logic (Set to 10 records per page as requested)
        int pageSize = 10;
        Products = await PaginatedList<Product>.CreateAsync(
            productIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
    }
}