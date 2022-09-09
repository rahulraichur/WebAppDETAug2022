using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Servics;

namespace WebAppDETAug2022.Pages
{
    public class HelloPageModel : PageModel
    {   
        
        public IHello ob { get; set; }
        public string Message { get; set; }
   
        public void OnGet()
        {
            //ob = new Hello1();
            //Message = ob.SayHello("Tony Stark");

            ob = new Hello2();
            Message = ob.SayHello("Tony Stark");
        }
    }
}
