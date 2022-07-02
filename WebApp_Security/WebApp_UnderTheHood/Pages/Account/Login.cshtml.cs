using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp_UnderTheHood.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }

    }
    public class Credential
    {
        [Required]
        [MaxLength(30)]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}