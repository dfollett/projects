using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Pages
{
    public class MyProgramsModel : PageModel
    {
        private readonly ILogger<MyProgramsModel> _logger;

        public MyProgramsModel(ILogger<MyProgramsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}