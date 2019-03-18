using ComiCore.Video;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComiAPI.Services
{
    public class VideoServices : IVideoService
    {
        private readonly string filter;
        private readonly string videoFolderParh;
        private HttpClient _client;

        public VideoServices()
        {
            this.videoFolderParh = "D:/";
            this.filter = "*.mp4";
            _client = new HttpClient();
        }

        public List<VideoFileInfo> FindVideoFiles()
        {
            DirectoryInfo info = new DirectoryInfo(this.videoFolderParh);
            List<VideoFileInfo> result = new List<VideoFileInfo>();
            foreach (FileInfo file in info.GetFiles("*.mp4"))
            {
                VideoFileInfo videoFile = new VideoFileInfo()
                {
                    DisplayName = file.Name,
                    Id = file.Name
                };
                result.Add(videoFile);
            }

            return result;
        }

        public IVideoFile GetVideoFile(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string path = Path.Combine(this.videoFolderParh, id);
            FileInfo info = new FileInfo(path);
            if (info.Exists)
            {
                FileVideoFile videoFile = new FileVideoFile(info);
                return videoFile;
            }
            else
            {
                return null;
            }
        }



        public async Task<Stream> GetVideoByName(string name)
        {
            var urlBlob = string.Empty;
            switch (name)
            {
                case "earth":
                    urlBlob = "https://anthonygiretti.blob.core.windows.net/videos/earth.mp4";
                    break;
                case "nature1":
                    urlBlob = "https://anthonygiretti.blob.core.windows.net/videos/nature1.mp4";
                    break;
                case "nature2":
                default:
                    urlBlob = "https://anthonygiretti.blob.core.windows.net/videos/nature2.mp4";
                    break;

            }

            return await _client.GetStreamAsync(urlBlob);
        }

        ~VideoServices()
        {
            if (_client != null)
                _client.Dispose();

        }
    }
}
