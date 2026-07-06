MicaelaPortfolio is my portfolio site: projects, skills, about, and contact. **Live site:** [micaelanilsson.se](https://micaelanilsson.se) (Netlify). Recruiters and visitors use the hosted URL — no need to clone or run anything locally.

Built as a **Blazor WebAssembly** app: the UI runs **client-side** in the browser (C# compiled to WebAssembly), with **client-side routing** between sections (`/`, `/about`, `/projects`, and so on). That pattern is often called a **single-page application (SPA)**: one `index.html` shell, then navigation without full page reloads — not “literally one long scrolling page.”


## Technology overview

**Framework:** Blazor WebAssembly (ASP.NET Core, .NET 8)

**Language & markup:** C# with Razor components, HTML5

**Styling:** SCSS (`wwwroot/css/app.scss` → `wwwroot/css/app.css`). `compilerconfig.json` is for the Web Compiler / Sass toolchain when I edit styles; the published site serves the compiled `app.css`.

**Architecture:** ASP.NET Core **dependency injection** in `Program.cs` — scoped services (`ProjectService`, `SkillService`) injected into Razor components. Project and skill data live in those services (in-memory lists), not a separate backend API.

**Data models:** `Project`, `Skill` in `Models/`; contact form model (`ContactForm`) in `Pages/Contact.razor`

**Contact:** Blazor `EditForm` with validation; submissions via **Netlify Forms** (JS helper + hidden form in `index.html`)

**Hosting:** Netlify (`netlify.toml`, `dotnet publish`, SPA fallback to `index.html`)

**UI details:** Responsive SCSS (flexbox, breakpoints), Font Awesome & Devicon, AOS scroll animations, meta/Open Graph in `index.html`, per-route `<PageTitle>`


## Core features

- **Client-side SPA:** Fast navigation after first load; all interaction in the browser.
- **Razor components:** Reusable UI (`ProjectCard`, `ProjectModal`, `FeaturedProjects`, layout/navigation).
- **Dependency injection:** Standard Blazor WASM service registration and constructor/`@inject` usage.
- **Responsive design:** Mobile-first layout in SCSS.
- **Accessibility & SEO:** Semantic HTML, descriptive titles, sharing metadata.


## For me (maintaining the repo)

When I change SCSS, I recompile to `app.css` (Web Compiler or `npx sass wwwroot/css/app.scss wwwroot/css/app.css`) before deploy. `dotnet run` is only for my own preview; `dotnet publish` is what Netlify uses on push.
