using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using ContosoCraftsWebSite.Models;
using ContosoCraftsWebSite.Services;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorViewModel : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorViewModel> _logger;

        public ErrorViewModel(ILogger<ErrorViewModel> logger) => _logger = logger;

        public void OnGet() => RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}
