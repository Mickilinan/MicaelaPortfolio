MicaelaPortfolio is a single-page portfolio application built with modern .NET technologies, showcasing my projects, skills and a contact form in a responsive, client-side experience.


**Technology Overview**

Framework: Blazor WebAssembly (ASP.NET Core, .NET 8)

Language & Markup: C# with Razor components, HTML5

Styling: SCSS compiled to CSS via dotnet-compiler-config (compilerconfig.json)

Dependency Injection & HTTP: Built-in ASP.NET Core DI with HttpClient for data fetching

Data Models: Plain C# classes (Project, Skill, ContactRequest)

Build & Tooling: .NET CLI (dotnet restore, dotnet run, dotnet publish) and Visual Studio Code

Version Control: Git & GitHub

Hosting: Netlify (configured with netlify.toml)

Fonts & Icons: Google Font “Inter” and custom favicon/app icons

**Core Features & Technologies**

Client-Side SPA: Fast, interactive UI built entirely in the browser.

Razor Components: Reusable UI units with C# logic.

Dependency Injection: Standard ASP.NET Core DI for easy testing and extensibility.

HTTP & JSON: HttpClient calls to static JSON or APIs, mapped to C# models.

Responsive Design: Mobile-first layout using SCSS and Flexbox.

Automated Deployment: Continuous deployment on Netlify with branch triggers.

Accessibility & SEO: Semantic HTML, proper meta tags via Next.js-like metadata configuration.
