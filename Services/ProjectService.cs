using MicaelaPortfolio.Models;

namespace MicaelaPortfolio.Services;

public class ProjectService
{
    private List<Project> _projects;

    public ProjectService()
    {
        _projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Model Monitor",
                    Description = "Model Monitor is an internal tool built as a take-home challenge for a Fullstack Developer role.",
                    IconClass = "fab fa-js-square",
                    Technologies = new List<string> { "Node.js", "React", "TypeScript", "PostgreSQL","TailwindCSS" },
                    GitHubUrl = "https://github.com/Mickilinan/model-monitor",
                    Screenshots = new List<string>
                    {
                        "/images/modelMonitorlogin.png",
                        "/images/modelMonitordashboard.png"
                    },
                    IsFeatured = true
                },
                new Project
{
    Id = 7,
    Title = "National Cat Adoption Platform",
    Description = "Free, nationwide adoption portal for cat shelters. Features include organization login, cat management, interest registration, and user-friendly search.",
    Technologies = new List<string> { "Next.js", "Supabase", "TailwindCSS",  "TypeScript" },
    Screenshots = new List<string>
    {
        "/images/catPortalLogin.png",
        "/images/catPortalDashboard.png",
        "/images/catPortalFront.png",
    },
    Badge = "In Development",
    IconClass = "fas fa-cat",
    IsFeatured = true

},
                new Project
{
    Id = 8,
    Title = "Catsona Quiz",
    Description = "A fun personality quiz that helps users discover their \"cat persona.\" Currently building the backend with plans to expand into a fullstack application.",
    Technologies = new List<string> { "React", "TailwindCSS", "C#", "TypeScript", "EF", "PostgreSQL" },

    Badge = "In Development",
    IconClass = "fas fa-compass",
    IsFeatured = true

},

                new Project
                {
                    Id = 2,
                    Title = "Admin Portal for Count On Me",
                    Description = "Administrative portal for the educational game Count On Me.",
                    IconClass = "fas fa-toolbox",
                    Technologies = new List<string> { "React", "TypeScript", "Prisma", "PostGreSQL", "TailwindCSS", "REST API (Express.js)" },
                    LiveUrl = "https://www.akribian.com/count-on-me",

                },
                new Project
                {
                    Id = 3,
                    Title = "CMS Umbraco Project",
                    Description = "School project focusing on content management systems using Umbraco.",
                    IconClass = "fas fa-file-alt",
                    Technologies = new List<string> { "C#", ".NET", "Umbraco","Azure", "HTML", "CSS",  },
                    GitHubUrl = "https://github.com/Mickilinan/CMSUmbraco",

                },
                new Project
                {
                    Id = 4,
                    Title = "Silicon Backend",
                    Description = "School project using advanced backend technologies.",
                    IconClass = "fas fa-server",
                    Technologies = new List<string> { "C#", ".NET", "Blazor", "GraphQL", "WebSockets", "REST API", "Azure", "Microservices", "HTML", "CSS" },
                    GitHubUrl = "https://github.com/silicon-jsb/SiliconBackoffice",

                },
                new Project
                {
                    Id = 5,
                    Title = "Shared Silicon",
                    Description = "School project, full-stack development using ASP .NET Core MVC.",
                    IconClass = "fas fa-layer-group",
                    Technologies = new List<string> { "C#", "ASP.NET Core", "MVC", "Entity Framework", "SQL", "SCSS", "HTML", "JavaScript", "REST API" },
                    GitHubUrl = "https://github.com/sarahk189/SharedSilicon",
                },
                new Project
                {
                    Id = 6,
                    Title = "Database Project",
                    Description = "School project, database design and implementation.",
                    IconClass = "fas fa-database",
                    Technologies = new List<string> { "C#", ".NET", "Entity Framework Core", "SQL", "SSMS" },
                    GitHubUrl = "https://github.com/Mickilinan/ConsoleApp",
                },

            };
    }

    public List<Project> GetProjects()
    {
        return _projects;
    }

    public Project GetProjectById(int id)
    {
        return _projects.FirstOrDefault(p => p.Id == id);
    }

    public List<Project> GetFeaturedProjects()
    {
        return _projects.Where(p => p.IsFeatured).ToList();
    }
}
