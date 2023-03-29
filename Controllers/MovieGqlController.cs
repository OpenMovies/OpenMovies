using API.Models.Movie;
using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using Newtonsoft.Json;

namespace API.Controllers;

public class MovieGqlController : GraphController
{
    [QueryRoot("movie")]
    public async Task<Movie?> Get(string shortName)
    {
        var r = new StreamReader($"Data/{shortName}.json");
        var jsonString = await r.ReadToEndAsync();
        var movie = JsonConvert.DeserializeObject<Movie>(jsonString);

        return movie;
    }
}