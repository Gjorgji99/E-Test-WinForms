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
        public User user;
        public string buttonNext = "Next"; 
        public bool buttonBack = true;
        public Question question;

        public TestModel()
        {

        }
        public void OnGet(){
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            ViewData["StudentName"] = user.Name;
            question = user.Test.Load;
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(this.user));

        }
        public IActionResult OnPostNext(string answer)
        {
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            if(1-user.Test.Count >0)
                buttonBack = false;
            else{
                buttonBack=true;
            }
            if(user.Test.Count==user.Test.NumberOfQuestions-2){
                buttonNext = "Finish";
            }
            question = user.Test.Next(answer);
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(this.user));
            return Page();
        }
        public IActionResult OnPostBack(){
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            buttonNext = "Next";
            if(1-user.Test.Count > 0)
                buttonBack = false;
            else{
                buttonBack=true;
            }
            question = user.Test.Back();
            ViewData["StudentName"] = user.Name;
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(this.user));
            return Page();
        }
        public IActionResult OnPostFinish(string answer){
            buttonBack = false;
            this.user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            user.Test.checkQuestion(answer);
            ViewData["StudentName"] = user.Name;
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(this.user));
            return RedirectToPage("/Result");
        }

    }
}
