using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ComiAPI.Services
{
    public interface IVideoService
    {
        Task<Stream> GetVideoByName(string name);
    }
}