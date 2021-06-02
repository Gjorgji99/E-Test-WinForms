using EtestLibrary.Models;
using EtestLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtestWebApp.Pages
{
    public class TestModel : PageModel
    {
        Etest test = new Etest("3" ,"mk-MK");
        public Question question;
        private readonly ILogger<PrivacyModel> _logger;
        public TestModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string name)
        {
            ViewData["StudentName"] = name;
            question = test.Load;
        }
        public void OnPost(string answer){

        }
    }
}
