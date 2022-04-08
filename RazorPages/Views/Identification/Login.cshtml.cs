using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Views.Identification
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credentials credential { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
