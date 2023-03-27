namespace API.Models.Movie;

public class Movie
{
    public string? Title { get; set; }
    public string? Shortname { get; set; }
    public string? Description { get; set; }
    public List<string?>? Genre { get; set; }
    public string? Rating { get; set; }
    public string? Language { get; set; }
    public List<Cast>? Cast { get; set; }
    public Crew? Crew { get; set; }
    public List<string?>? Distributor { get; set; }
    public BoxOffice? BoxOffice { get; set; }
    public Release? Release { get; set; }
    public List<string?>? CountryOfOrigin { get; set; }
    public Runtime? Runtime { get; set; }
    public List<int>? AspectRatio { get; set; }
}