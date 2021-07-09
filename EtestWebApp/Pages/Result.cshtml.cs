using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtestLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace EtestWebApp.Pages
{
    public class ResultModel : PageModel
    {
        public User user;
        public ResultModel(){
        }
        public void OnGet()
        {
            user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));

        }
    }
}
