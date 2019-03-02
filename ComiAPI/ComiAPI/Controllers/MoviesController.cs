using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComiCore;
using ComiCore.Model;
using System.IO;
using ComiAPI.Services;
using System.Net.Http.Headers;

namespace ComiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IVideoService _videoService;

        public MoviesController(ApplicationDbContext context, IVideoService videoService)
        {
            _context = context;
            _videoService = videoService;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<FileStreamResult> GetMovies()
        {
            var stream = await _videoService.GetVideoByName("earth"); // Set earth for demo, you must to replace by dynamic data
            return new FileStreamResult(stream, "video/mp4");
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movies>> GetMovies(int id)
        {
            //var movies = await _context.Movies.FindAsync(id);

            //if (movies == null)
            //{
            //    return NotFound();
            //}

            //return movies;
            var demoPath = "C:/Users/User/Videos/Captures/6_3_2018.mp4";
            byte[] fileData;

            using (FileStream fs = System.IO.File.OpenRead(demoPath))
            {
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    fileData = binaryReader.ReadBytes((int)(fs.Length * 0.6));
                }
            }

            MemoryStream stream = new MemoryStream(fileData);
            return new FileStreamResult(stream, new MediaTypeHeaderValue("audio/mpeg").MediaType);

        }

        // PUT: api/Movies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovies(int id, Movies movies)
        {
            if (id != movies.Id)
            {
                return BadRequest();
            }

            _context.Entry(movies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoviesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movies
        [HttpPost]
        public async Task<ActionResult<Movies>> PostMovies(Movies movies)
        {
            _context.Movies.Add(movies);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovies", new { id = movies.Id }, movies);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movies>> DeleteMovies(int id)
        {
            var movies = await _context.Movies.FindAsync(id);
            if (movies == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movies);
            await _context.SaveChangesAsync();

            return movies;
        }

        private bool MoviesExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
