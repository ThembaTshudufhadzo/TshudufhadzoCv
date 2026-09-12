# Tshudufhadzo Themba — Portfolio & Interactive CV

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Docker](https://img.shields.io/badge/Docker-Ready-2496ED?logo=docker&logoColor=white)](https://www.docker.com/)

A modern, responsive portfolio web application built with **ASP.NET Core MVC (.NET 8)** and containerized using **Docker** for cloud deployment. The platform showcases academic credentials, technical competencies, and project history, while offering an integrated in-browser preview and direct download of a professional curriculum vitae.

---

##  Live Deployments & Links

* **Live Demo (Somee):** [http://tshuduthemba.somee.com](http://tshuduthemba.somee.com)
* **GitHub Repository:** [https://github.com/ThembaTshudufhadzo/TshudufhadzoCv](https://github.com/ThembaTshudufhadzo/TshudufhadzoCv)

---

##  Tech Stack & Tools

* **Backend:** C# 12, ASP.NET Core 8.0 MVC
* **Database & ORM:** Entity Framework Core, SQLite
* **Frontend:** Razor Views, HTML5, CSS3, JavaScript, Bootstrap 5.3 (CDN), Bootstrap Icons
* **DevOps & Containerization:** Docker (multi-stage build), Git, GitHub
* **Hosting:** Somee (Windows IIS) / Render-ready (Linux container)

---

## ✨ Key Features

* **Interactive Presentation:** Responsive, mobile-first grid presenting career summaries, skills, and certifications.
* **Direct CV Access:** Integrated document actions enabling instant in-browser inspection and direct PDF downloads via `wwwroot`.
* **Quick Contact Card:** Preconfigured triggers for immediate email, SMS, and developer profile links.
* **Containerized Build:** Optimized multi-stage Docker build separating compilation and runtime dependencies for lean deployment.

---

##  Repository Structure

```text
├── Dockerfile                  # Multi-stage container build configuration
├── .dockerignore               # Build context ignore rules
├── TshuduCV.slnx               # Visual Studio Solution file
└── TshuduCV/
    ├── Controllers/            # MVC routing & controllers (HomeController.cs)
    ├── Data/                   # ApplicationDbContext and SQLite migrations
    ├── Models/                 # Domain and presentation models
    ├── Views/                  # Razor views and shared layouts (_Layout.cshtml)
    ├── wwwroot/                # Static assets, styling, and downloadable PDF CV
    ├── appsettings.json        # Environment configurations
    ├── Program.cs              # Middleware pipeline and service registration
    └── TshuduPortfolioApp.csproj
