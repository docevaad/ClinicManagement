﻿using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using Tortuga.Chain;

namespace ClinicManagement.Web.Infrastructure.Filters
{
    public class ResourceNotFoundExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// Raises the exception event.
        /// </summary>
        /// <param name="actionExecutedContext">The context for the action.</param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is MissingDataException)
            {
                actionExecutedContext.Response = new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Content = new StringContent("Resource not found.")
                };
            }
        }
    }
}
