using EtestLibrary.Models;
using EtestLibrary.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtestWebApp.Pages
{
    public class TestModel : PageModel
    {
        public User user = new User();
        public string buttonNext = "Next"; 
        public Question question;

        public TestModel()
        {

        }
        public void OnGet(){
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            ViewData["StudentName"] = user.Name;
             question = user.Test.Load;
        }
        public IActionResult OnPostNext(string answer)
        {
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            if(user.Test.Count==user.Test.NumberOfQuestions-2){
                buttonNext = "Finish";
            }
            question = user.Test.Next(answer);
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(user));
           
            return Page();
        }
        public IActionResult OnPostBack(){
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            question = user.Test.Back();
            ViewData["StudentName"] = user.Name;
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(user));
            return Page();
        }
        public IActionResult OnPostFinish(string answer){
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            user.Test.checkQuestion(answer);
            ViewData["StudentName"] = user.Name;
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(user));
            return RedirectToPage("/Result");
        }

    }
}
