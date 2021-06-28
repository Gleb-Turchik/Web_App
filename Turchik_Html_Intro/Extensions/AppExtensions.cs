using Microsoft.AspNetCore.Builder;
using Turchik_Html_Intro.Middleware;

namespace Turchik_Html_Intro.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        {
          return app.UseMiddleware<LogMiddleware>();
        }
    }
}
