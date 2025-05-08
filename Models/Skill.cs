namespace MicaelaPortfolio.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; } // "frontend", "backend", "other"
    public int ProficiencyLevel { get; set; } // 0-100
    public string IconPath { get; set; }
}
