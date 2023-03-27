using API.Models.Movie;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers;

[Controller]
[Route("[controller]")]
public class MovieController : Controller
{
    [HttpGet("{shortName}")]
    public async Task<ActionResult<Movie>> Get(string? shortName)
    {
        if (shortName == null)
        {
            return BadRequest("Movie name is required!");
        }

        try
        {
            var r = new StreamReader($"Data/{shortName}.json");
            var jsonString = await r.ReadToEndAsync();
            var movie = JsonConvert.DeserializeObject<Movie>(jsonString);

            return movie!;
        }
        catch (Exception e)
        {
            return NotFound($"Movie not found!: {e.Message}");
        }
    }
}