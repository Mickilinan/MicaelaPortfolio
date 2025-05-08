using MicaelaPortfolio.Models;

namespace MicaelaPortfolio.Services;

public class SkillService
{
    private List<Skill> _skills;

    public SkillService()
    {
        _skills = new List<Skill>
            {
                // Frontend Skills
                new Skill { Id = 1, Name = "Blazor", Category = "frontend", ProficiencyLevel = 50, IconPath = "/images/skills/blazor.png" },
                new Skill { Id = 2, Name = "HTML", Category = "frontend", ProficiencyLevel = 90, IconPath = "/images/skills/html.png" },
                new Skill { Id = 3, Name = "CSS", Category = "frontend", ProficiencyLevel = 85, IconPath = "/images/skills/css.png" },
                new Skill { Id = 4, Name = "JavaScript", Category = "frontend", ProficiencyLevel = 40, IconPath = "/images/skills/javascript.png" },
                new Skill { Id = 5, Name = "React", Category = "frontend", ProficiencyLevel = 60, IconPath = "/images/skills/react.png" },
                new Skill { Id = 15, Name = "TypeScript", Category = "frontend", ProficiencyLevel = 60, IconPath = "/images/skills/typescript.png" },
                new Skill { Id = 6, Name = "Tailwind CSS", Category = "frontend", ProficiencyLevel = 70, IconPath = "/images/skills/tailwind.png" },
                
                // Backend Skills
                new Skill { Id = 7, Name = "C#", Category = "backend", ProficiencyLevel = 90, IconPath = "/images/skills/csharp.png" },
                new Skill { Id = 8, Name = "ASP .NET Core", Category = "backend", ProficiencyLevel = 85, IconPath = "/images/skills/dotnet.png" },
                new Skill { Id = 16, Name = "Node.js", Category = "backend", ProficiencyLevel = 40, IconPath = "/images/skills/nodejs.png" },
                new Skill { Id = 9, Name = "SQL Server", Category = "backend", ProficiencyLevel = 70, IconPath = "/images/skills/sql.png" },
                new Skill { Id = 10, Name = "Entity Framework", Category = "backend", ProficiencyLevel = 70, IconPath = "/images/skills/ef.png" },
                
                
                
                
                // Other Skills
                new Skill { Id = 14, Name = "GitHub", Category = "other", ProficiencyLevel = 85, IconPath = "/images/skills/git.png" },
                new Skill { Id = 13, Name = "Umbraco", Category = "other", ProficiencyLevel = 50, IconPath = "/images/skills/umbraco.png" },
                new Skill { Id = 18, Name = "ClickUp", Category = "other", ProficiencyLevel = 85, IconPath = "/images/skills/microsoft.png" },
                new Skill { Id = 11, Name = "Azure", Category = "other", ProficiencyLevel = 40, IconPath = "/images/skills/azure.png" },

            };
    }

    public List<Skill> GetSkills()
    {
        return _skills;
    }

    public List<Skill> GetSkillsByCategory(string category)
    {
        return _skills.Where(s => s.Category == category).ToList();
    }
}
