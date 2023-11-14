using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicLibraryBackendWebAPI.Data;
using MusicLibraryBackendWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryBackendWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SongsController(ApplicationDBContext context)
        {
            _context = context;
        }
        
        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs.ToList();
            return Ok(songs);
        }

        // GET api/Songs
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var songs = _context.Songs.FirstOrDefault(song => song.Id == id);
            
            if(songs == null)
            {
                return NotFound();
            }
                
            return Ok(songs);
        }

        // POST api/Songs
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);
        }

        // PUT api/Songs
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            if (song == null)
            {
                return NotFound();
            }

            var oldSong = _context.Songs.FirstOrDefault(song => song.Id == id);

            if (oldSong == null)
            {
                return NotFound();
            }

            oldSong.Title = song.Title;
            oldSong.Artist = song.Artist;
            oldSong.Album = song.Album;
            oldSong.ReleaseDate = song.ReleaseDate;
            oldSong.Genre = song.Genre;

            _context.SaveChanges();

            return Ok(oldSong);
        }

        // DELETE api/Songs
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.FirstOrDefault(song => song.Id == id);

            if (song == null)
            {
                return NotFound();
            }

            _context.Songs.Remove(song);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
