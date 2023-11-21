using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Principal;

namespace LoginRegisterWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string pageTitle { get; set; }
        public bool isProcessed { get; private set; } = false;
        public string Email { get; set; }

        public IndexModel()
        {
            pageTitle = "LoginRegister";
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            this.Email = Request.Form["email"];
            string password = Request.Form["password"];

            if (Email == "amrit@gmail.com")
            {
                isProcessed = true;
            }
            else
            {
                isProcessed = true;
            }
        }
    }
}