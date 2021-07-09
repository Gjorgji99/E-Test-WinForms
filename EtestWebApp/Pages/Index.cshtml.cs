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
    public class IndexModel : PageModel
    {

        public IndexModel()
        {

        }
        
        public ActionResult OnGet(string name){
            if(name == null){
                return Page();
            }
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(new User(name,new Etest("3" ,"mk-MK"))));
            return RedirectToPage("/Test");
        }
    }
}
