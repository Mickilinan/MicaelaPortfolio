namespace MicaelaPortfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string IconClass { get; set; }
    public List<string> Technologies { get; set; } = new List<string>();
    public string GitHubUrl { get; set; }
    public string LiveUrl { get; set; }
    public List<string> Images { get; set; } = new List<string>();
    public List<string>? Screenshots { get; set; }
    public string? Badge { get; set; }
    public string? Category { get; set; }
    public bool IsFeatured { get; set; } = false;

}
