using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtestLibrary;
using EtestLibrary.Models;
using EtestLibrary.Services;
namespace EtestWebApp.Pages
{ 
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Question> questions = DataBaseService.loadQuestions("mk-MK");
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
