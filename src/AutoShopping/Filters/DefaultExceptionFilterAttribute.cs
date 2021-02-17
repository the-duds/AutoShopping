using AutoShopping.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace AutoShopping.Filters
{
    /// <summary>
    /// Filtro de Exceções
    /// </summary>
    public class DefaultExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            //Log.Error(context.Exception, context.Exception.Message);

            context.Result = new ObjectResult(new ErrorResult(context.Exception.Message))
            {
                StatusCode = HttpStatusCode.InternalServerError.GetHashCode()
            };
        }
    }
}
