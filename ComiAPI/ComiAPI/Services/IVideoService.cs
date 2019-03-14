using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComiAPI.Services
{
    public interface IVideoService
    {
        Task<Stream> GetVideoByName(string name);
    }
}