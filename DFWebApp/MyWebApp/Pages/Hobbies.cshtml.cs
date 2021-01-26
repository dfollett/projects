using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Pages
{
    public class HobbiesModel : PageModel
    {
        private readonly ILogger<HobbiesModel> _logger;

        public HobbiesModel(ILogger<HobbiesModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}