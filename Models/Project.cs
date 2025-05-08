namespace MicaelaPortfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string DetailedDescription { get; set; }
    public string Category { get; set; } // "professional" or "school"
    public string IconClass { get; set; }
    public string Badge { get; set; }
    public List<string> Technologies { get; set; } = new List<string>();
    public string GitHubUrl { get; set; }
    public string LiveUrl { get; set; }
    public List<string> Features { get; set; } = new List<string>();
    public List<string> Images { get; set; } = new List<string>();
    public string VideoUrl { get; set; }
    public string ClientName { get; set; }
    public string Duration { get; set; }
    public string Role { get; set; }
    public List<string> Challenges { get; set; } = new List<string>();
    public List<string> Solutions { get; set; } = new List<string>();
}
