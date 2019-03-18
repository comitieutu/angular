using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ComiCore.Video
{
    public interface IVideoFile
    {
        string ContentType
        {
            get;
        }

        string Name
        {
            get;
        }

        long Size
        {
            get;
        }

        Task CopyTo(Stream outputStream);

        Task CopyTo(Stream outputStream, long begin, long end);
    }
}
