using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiAPI.Middleware
{
    public static class VideoStreamMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestStream(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<VideoStreamMiddleware>();
        }
    }
}
