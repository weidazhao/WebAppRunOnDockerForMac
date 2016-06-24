using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace WorksOnMyMachine
{
    public class CatchAllMiddleware
    {
        private readonly RequestDelegate _next;

        public CatchAllMiddleware(RequestDelegate next)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync(ex.ToString());
            }
        }
    }
}