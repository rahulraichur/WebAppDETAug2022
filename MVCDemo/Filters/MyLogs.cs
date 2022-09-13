using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Cryptography.X509Certificates;

namespace MVCDemo.Filters
{
    public class MyLogs:ActionFilterAttribute
        
    {
        public override void OnActionExecuting(ActionExecutingContext Context)
        {
            Console.WriteLine($"- {nameof(MyLogs)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuting(Context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
                {
                Console.WriteLine($"- {nameof(MyLogs)}.{nameof(OnActionExecuted)}");
                base.OnActionExecuted(context);
                }
        }


    }
}
