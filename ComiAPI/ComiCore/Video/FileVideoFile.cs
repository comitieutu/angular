using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ComiCore.Video
{
    public class FileVideoFile : IVideoFile
    {
        private const int bufferLenght = 1024 * 1024;

        private readonly string fullPath;

        public string ContentType
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public long Size
        {
            get;
            protected set;
        }

        public FileVideoFile(FileInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            this.fullPath = info.FullName;
            this.Name = info.Name;
            this.Size = info.Length;
        }

        public async Task CopyTo(Stream outputStream)
        {
            if (outputStream == null) throw new ArgumentNullException(nameof(outputStream));

            using (FileStream fs = new FileStream(this.fullPath, FileMode.Open))
            {
                await fs.CopyToAsync(outputStream);
            }
        }

        public async Task CopyTo(Stream outputStream, long begin, long end)
        {
            if (outputStream == null) throw new ArgumentNullException(nameof(outputStream));

            long remainingBytes = end - begin + 1;
            long position = begin;
            int count;
            byte[] buffer = new byte[bufferLenght];

            using (FileStream fs = new FileStream(this.fullPath, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(begin, SeekOrigin.Begin);
                do
                {
                    if (remainingBytes > bufferLenght)
                    {
                        count = await fs.ReadAsync(buffer, 0, bufferLenght).ConfigureAwait(false);
                        await outputStream.WriteAsync(buffer, 0, count).ConfigureAwait(false);
                    }
                    else
                    {
                        count = await fs.ReadAsync(buffer, 0, (int)remainingBytes).ConfigureAwait(false);
                        await outputStream.WriteAsync(buffer, 0, count).ConfigureAwait(false);
                    }

                    position += count;
                    remainingBytes -= count;
                }
                while (position <= end);
            }
        }
    }
}
