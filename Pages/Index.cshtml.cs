using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld_ASP_Razor.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Result { get; set; }

        //some change
        public void OnGet()
        {

        }

        public void OnPost()
        {
            Result = $"Hello {Name}, you are {Age} years old!";
        }

    }
}
