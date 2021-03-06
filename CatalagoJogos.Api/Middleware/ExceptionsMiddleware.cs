using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CatalagoJogos.Api.Middleware
{
    public class ExceptionsMiddleware
    {
        public class ExceptionMiddleware
        {
            private readonly RequestDelegate _next;

            public ExceptionMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task InvokeAsync(HttpContext context)
            {
                try
                {
                    await _next(context);
                }
                catch
                {
                    await HandleExceptionAsync(context);
                }
            }

            private static async Task  HandleExceptionAsync(HttpContext context)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsJsonAsync(new { Message = " Ocorreu um erro durante a sua solicitação, tente novamente mais tarde. " });
            }
        }
    }
}
