using Microsoft.AspNetCore.Mvc;
using CrazyMusicians.Models;

namespace CrazyMusicians.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusiciansController : ControllerBase
    {
        private static List<Musician> _musicians = new List<Musician>
        {
            new Musician { Id = 1, Name = "John NoteSinger", Profession = "Famous Note Singer", FunnyTrait = "Always sings wrong notes but very entertaining" },
            new Musician { Id = 2, Name = "Mary Melody", Profession = "Popular Melody Writer", FunnyTrait = "Writes confusing melodies that become hits" },
            new Musician { Id = 3, Name = "Charlie Chord", Profession = "Wild Chord Player", FunnyTrait = "Changes chords randomly but surprisingly talented" },
            new Musician { Id = 4, Name = "Flora Note", Profession = "Surprise Note Producer", FunnyTrait = "Creates unexpected notes during performances" },
            new Musician { Id = 5, Name = "Harry Rhythm", Profession = "Rhythm Explorer", FunnyTrait = "Makes his own rhythm, never matches but funny" }
        };

        // GET: api/musicians
        [HttpGet]
        public ActionResult<IEnumerable<Musician>> GetMusicians()
        {
            return Ok(_musicians);
        }

        // GET: api/musicians/search?name={name}
        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> SearchMusicians([FromQuery] string name)
        {
            var musicians = _musicians.Where(m => 
                m.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            return Ok(musicians);
        }

        // GET: api/musician/{id}
        [HttpGet("{id:int}")]
        public ActionResult<Musician> GetMusician(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Musician not found");
            return Ok(musician);
        }

        // POST: api/musician
        [HttpPost]
        public ActionResult<Musician> CreateMusician([FromBody] MusicianDTO musicianDto)
        {
            var musician = new Musician
            {
                Id = _musicians.Max(m => m.Id) + 1,
                Name = musicianDto.Name,
                Profession = musicianDto.Profession,
                FunnyTrait = musicianDto.FunnyTrait
            };

            _musicians.Add(musician);
            return CreatedAtAction(nameof(GetMusician), new { id = musician.Id }, musician);
        }

        // PUT: api/musician/{id}
        [HttpPut("{id:int}")]
        public ActionResult UpdateMusician(int id, [FromBody] MusicianDTO musicianDto)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Musician not found");

            musician.Name = musicianDto.Name;
            musician.Profession = musicianDto.Profession;
            musician.FunnyTrait = musicianDto.FunnyTrait;

            return NoContent();
        }

        // DELETE: api/musician/{id}
        [HttpDelete("{id:int}")]
        public ActionResult DeleteMusician(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Musician not found");

            _musicians.Remove(musician);
            return NoContent();
        }
    }
}
