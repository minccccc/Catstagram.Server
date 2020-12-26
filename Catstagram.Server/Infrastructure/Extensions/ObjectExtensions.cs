using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagram.Server.Infrastructure.Extensions
{
    public static class ObjectExtensions
    {
        //Option 1 for catching all errors for model == null in controllers
        public static ActionResult<TModel> OrnOtFound<TModel>(this TModel model)
        {
            if (model == null)
            {
                return new NotFoundResult();
            }

            return model;
        }
    }
}
