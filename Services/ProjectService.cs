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
                    Title = "Admin Portal for Count On Me",
                    Description = "Administrative portal for the educational game Count On Me.",
                    DetailedDescription = "Developed a comprehensive administrative portal for the educational game 'Count On Me'. This portal allows administrators to manage user accounts and customize game settings. The system was built with scalability in mind to accommodate growing user numbers and additional features.",
                    Category = "professional",
                    IconClass = "fas fa-toolbox",
                    Technologies = new List<string> { "React", "TypeScript", "Prisma", "PostGreSQL", "TailwindCSS" },
                    LiveUrl = "https://www.akribian.com/count-on-me",
                    Features = new List<string>
                    {
                        "User management system with role-based access control",
                        "Real-time analytics dashboard for monitoring student progress",
                        "Customizable game settings and difficulty levels",
                        "Detailed reporting system with exportable data",
                        "Content management for educational materials"
                    },
                    Images = new List<string> { "/images/projects/admin-portal-1.jpg", "/images/projects/admin-portal-2.jpg" },
                    ClientName = "Educational Technology Company",
                    Duration = "3 months",
                    Role = "Lead Developer",
                    Challenges = new List<string>
                    {
                        "Integrating with existing game infrastructure",
                        "Ensuring data security for sensitive student information",
                        "Building an intuitive interface for non-technical administrators"
                    },
                    Solutions = new List<string>
                    {
                        "Developed a robust API layer to communicate with the game system",
                        "Implemented comprehensive authentication and authorization",
                        "Created a user-centered design with extensive usability testing"
                    }
                },
                new Project
                {
                    Id = 2,
                    Title = "CMS Umbraco Project",
                    Description = "School project focusing on content management systems using Umbraco.",
                    DetailedDescription = "This school project involved creating a fully functional website using Umbraco CMS. The goal was to demonstrate proficiency in content management systems while building a responsive, user-friendly website. The project included custom document types, templates, and macros to create a flexible content structure.",
                    Category = "school",
                    IconClass = "fas fa-file-alt",
                    Technologies = new List<string> { "C#", ".NET", "Umbraco","Azure", "HTML", "CSS",  },
                    GitHubUrl = "https://github.com/Mickilinan/CMSUmbraco",
                    Features = new List<string>
                    {
                        "Custom document types and templates",
                        "Responsive design for all device sizes",
                        "Content approval workflow",
                        "Media management system",
                        "Custom Umbraco macros and extensions"
                    },
                    Images = new List<string> { "/images/projects/umbraco-1.jpg", "/images/projects/umbraco-2.jpg" },
                    Duration = "6 weeks",
                    Role = "Full-stack Developer",
                    Challenges = new List<string>
                    {
                        "Learning Umbraco's architecture and API",
                        "Implementing complex content relationships",
                        "Creating a user-friendly editing experience"
                    },
                    Solutions = new List<string>
                    {
                        "Extensive research and documentation review",
                        "Designed a clear content hierarchy with intuitive navigation",
                        "Created custom property editors for specific content needs"
                    }
                },
                new Project
                {
                    Id = 3,
                    Title = "Silicon Backend",
                    Description = "School project using advanced backend technologies.",
                    DetailedDescription = "This backend project focused on building a robust API and database architecture for a fictional e-commerce platform. The system was designed to handle product management, user authentication, order processing, and inventory tracking. Special attention was paid to performance optimization and security considerations.",
                    Category = "school",
                    IconClass = "fas fa-server",
                    Technologies = new List<string> { "C#", ".NET", "Blazor", "GraphQL", "WebSockets", "REST API", "Azure", "Microservices", "HTML", "CSS" },
                    GitHubUrl = "https://github.com/silicon-jsb/SiliconBackoffice",
                    Features = new List<string>
                    {
                        "RESTful API with comprehensive documentation",
                        "JWT authentication and authorization",
                        "Database migrations and seeding",
                        "Caching mechanisms for improved performance",
                        "Comprehensive logging and error handling"
                    },
                    Images = new List<string> { "/images/projects/silicon-1.jpg", "/images/projects/silicon-2.jpg" },
                    Duration = "8 weeks",
                    Role = "Backend Developer",
                    Challenges = new List<string>
                    {
                        "Designing a scalable database schema",
                        "Implementing efficient query patterns",
                        "Ensuring data consistency across operations"
                    },
                    Solutions = new List<string>
                    {
                        "Used Code-First approach with careful entity design",
                        "Implemented repository pattern with optimized queries",
                        "Created transaction management for critical operations"
                    }
                },
                new Project
                {
                    Id = 4,
                    Title = "Shared Silicon",
                    Description = "School project, full-stack development using ASP .NET Core MVC.",
                    DetailedDescription = "Shared Silicon was a collaborative school project to create a full-stack web application for a fictional technology marketplace. The application allows users to browse products, create accounts, manage their shopping cart, and complete purchases. The project demonstrated the team's ability to work with ASP.NET Core MVC architecture and implement both frontend and backend functionality.",
                    Category = "school",
                    IconClass = "fas fa-layer-group",
                    Technologies = new List<string> { "C#", "ASP.NET Core", "MVC", "Entity Framework", "SQL", "SCSS", "HTML", "JavaScript" },
                    GitHubUrl = "https://github.com/sarahk189/SharedSilicon",
                    Features = new List<string>
                    {
                        "User authentication and profile management",
                        "Product catalog with search and filtering",
                        "Shopping cart and checkout process",
                        "Order history and tracking",
                        "Admin panel for product and user management"
                    },
                    Images = new List<string> { "/images/projects/shared-silicon-1.jpg", "/images/projects/shared-silicon-2.jpg" },
                    Duration = "10 weeks",
                    Role = "Full-stack Developer",
                    Challenges = new List<string>
                    {
                        "Coordinating development efforts across team members",
                        "Integrating different system components",
                        "Managing state across the application"
                    },
                    Solutions = new List<string>
                    {
                        "Established clear coding standards and regular code reviews",
                        "Used interface-based design for loose coupling",
                        "Implemented session management and state persistence"
                    }
                },
                new Project
                {
                    Id = 5,
                    Title = "Database Project",
                    Description = "School project, database design and implementation.",
                    DetailedDescription = "This project focused on designing and implementing a relational database for a library management system. The database was designed to track books, patrons, loans, reservations, and other library operations. The project included creating the database schema, writing stored procedures, implementing triggers, and developing a simple console application to interact with the database.",
                    Category = "school",
                    IconClass = "fas fa-database",
                    Technologies = new List<string> { "C#", ".NET", "Entity Framework Core", "SQL", "SSMS" },
                    GitHubUrl = "https://github.com/Mickilinan/ConsoleApp",
                    Features = new List<string>
                    {
                        "Normalized database design",
                        "Complex queries and reporting",
                        "Stored procedures and functions",
                        "Triggers for data integrity",
                        "Transaction management"
                    },
                    Images = new List<string> { "/images/projects/database-1.jpg", "/images/projects/database-2.jpg" },
                    Duration = "5 weeks",
                    Role = "Database Developer",
                    Challenges = new List<string>
                    {
                        "Designing an efficient schema with proper normalization",
                        "Handling complex relationships between entities",
                        "Ensuring data integrity across operations"
                    },
                    Solutions = new List<string>
                    {
                        "Applied database normalization principles to 3NF",
                        "Used foreign keys and constraints to maintain relationships",
                        "Implemented triggers and stored procedures for data validation"
                    }
                },
                new Project
                {
                    Id = 6,
                    Title = "JavaScript Frontend",
                    Description = "School project, modern frontend development using React.",
                    DetailedDescription = "This frontend project involved creating a modern, responsive web application using React. The application was a dashboard for a fictional analytics platform, featuring interactive charts, data tables, and user management interfaces. The project demonstrated proficiency in modern JavaScript frameworks and responsive design principles.",
                    Category = "school",
                    IconClass = "fab fa-js-square",
                    Technologies = new List<string> { "JavaScript", "React" },
                    GitHubUrl = "https://github.com/Mickilinan/jsfrontend",
                    Features = new List<string>
                    {
                        "Interactive data visualization with Chart.js",
                        "Responsive design for all device sizes",
                        "State management with Redux",
                        "Form validation and error handling",
                        "Dark/light theme toggle"
                    },
                    Images = new List<string> { "/images/projects/js-frontend-1.jpg", "/images/projects/js-frontend-2.jpg" },
                    Duration = "7 weeks",
                    Role = "Frontend Developer",
                    Challenges = new List<string>
                    {
                        "Creating responsive layouts for complex data visualizations",
                        "Managing application state across components",
                        "Optimizing performance for large datasets"
                    },
                    Solutions = new List<string>
                    {
                        "Used CSS Grid and Flexbox for responsive layouts",
                        "Implemented Redux for centralized state management",
                        "Applied lazy loading and virtualization techniques"
                    }
                }
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
        return _projects.Where(p => p.Badge == "Featured").ToList();
    }

    public List<Project> GetRelatedProjects(int currentProjectId, string category, int count = 3)
    {
        return _projects
            .Where(p => p.Id != currentProjectId && p.Category == category)
            .Take(count)
            .ToList();
    }
}
