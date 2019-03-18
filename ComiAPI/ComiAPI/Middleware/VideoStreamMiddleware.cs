using ComiAPI.Services;
using ComiCore.Video;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiAPI.Middleware
{
    public class VideoStreamMiddleware
    {
        private readonly IVideoService videoService;
        private readonly RequestDelegate next;

        private const long maxTransfer = 1024 * 1024;

        public VideoStreamMiddleware(RequestDelegate next, IVideoService videoService)
        {
            if (next == null) throw new ArgumentNullException(nameof(next));
            if (videoService == null) throw new ArgumentNullException(nameof(videoService));

            this.next = next;
            this.videoService = videoService;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (!httpContext.Request.Path.StartsWithSegments(new PathString("/videostream")))
            {
                await this.next(httpContext);
                return;
            }

            string id = httpContext.Request.Query["file"];
            IVideoFile videoFile = this.videoService.GetVideoFile(id);
            if (videoFile == null)
            {
                httpContext.Response.StatusCode = 404;
                return;
            }

            string header = httpContext.Request.Headers["Range"];
            long begin, end;

            if (this.TryRangeParse(header, videoFile, out begin, out end))
            {
                end = Math.Min(begin + maxTransfer, end);

                if (begin >= videoFile.Size || end > videoFile.Size)
                {
                    httpContext.Response.StatusCode = 416;
                    httpContext.Response.Headers.Add("Content-Range", $"bytes */{videoFile.Size}");
                    return;
                }

                httpContext.Response.StatusCode = 206;
                string rangeOut = $"bytes {begin}-{end}/{videoFile.Size}";
                httpContext.Response.ContentType = videoFile.ContentType;

                httpContext.Response.Headers.Add("Accept-Ranges", "bytes");
                httpContext.Response.Headers.Add("Content-Range", new Microsoft.Extensions.Primitives.StringValues(rangeOut));
                httpContext.Response.Headers.Add("Cache-Control", "no-cache");

                await videoFile.CopyTo(httpContext.Response.Body, begin, end);
            }
            else
            {
                httpContext.Response.ContentType = videoFile.ContentType;
                httpContext.Response.Headers.Add("Accept-Ranges", "bytes");
                httpContext.Response.Headers.Add("Cache-Control", "no-cache");

                await videoFile.CopyTo(httpContext.Response.Body);
            }
        }

        private bool TryRangeParse(string range, IVideoFile videoFile, out long begin, out long end)
        {
            const string bytesPrefix = "bytes=";
            begin = 0L;
            end = 0L;

            if (string.IsNullOrEmpty(range) || !range.StartsWith(bytesPrefix, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            string rangeValues = range.Substring(bytesPrefix.Length);
            int delimiterIndex = rangeValues.IndexOf('-');

            if (!long.TryParse(rangeValues.Substring(0, delimiterIndex), out begin))
            {
                begin = 0L;
            }
            if (!long.TryParse(rangeValues.Substring(delimiterIndex + 1), out end))
            {
                end = videoFile.Size - 1;
            }

            return true;
        }
    }
}
