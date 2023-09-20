using ContosoCraftsWebSite.Models;
using ContosoCraftsWebSite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCraftsWebSite.Pages
{
 
    
    
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
    
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet() => Products = ProductService.GetProducts();
    }
}


