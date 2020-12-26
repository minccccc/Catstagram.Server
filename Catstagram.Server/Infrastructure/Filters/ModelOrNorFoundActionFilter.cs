using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagram.Server.Infrastructure.Filters
{
    public class ModelOrNorFoundActionFilter : ActionFilterAttribute
    {
        //Option 2 for catching all errors for model == null in controllers
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult result)
            {
                var model = result.Value;

                if(model == null)
                {
                    context.Result = new NotFoundResult();
                }
            }
        }

    }
}
