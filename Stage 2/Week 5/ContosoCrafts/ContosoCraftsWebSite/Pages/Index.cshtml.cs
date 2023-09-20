﻿using System.Collections.Generic;
using ContosoCraftsWebSite.Models;
using ContosoCraftsWebSite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCraftsWebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product>? Products { get; private set; }

        public void OnGet() => Products = ProductService.GetProducts();
    }
}