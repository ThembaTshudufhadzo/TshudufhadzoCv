using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TshuduCV.Data;
using TshuduCV.Models;

namespace TshuduCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var profile = await _context.UserProfiles
                .Include(p => p.Projects)
                .Include(p => p.Experience)
                .FirstOrDefaultAsync();

            if (profile == null)
            {
                profile = new UserProfile
                {
                    FullName = "Tshudufhadzo Themba",
                    ProfessionalTitle = "Full-Stack Mobile & Web Developer",
                    AboutMe = "Results-driven Application Developer and Developer Analyst with a strong academic foundation in software engineering, multi-tier architectures, and systems design. Experienced in mobile and desktop development using Java, C#, and Kotlin, alongside relational database management with SQL schemas, triggers, and automated constraints. Certified in Google AI Essentials with proven skills in prompt engineering, Azure cloud storage pipelines, and developing resilient, data-driven software solutions.",
                    Education = "Bachelor of Computer Science & IT in Application Development — EMERIS (Formerly IIE MSA) | Jan 2024 – Present (Expected 2027)",
                    Address = "Roodepoort, Gauteng, South Africa",
                    Email = "tshudufhadzoshudu@gmail.com",
                    LinkedIn = "https://www.linkedin.com/in/tshudufhadzo",
                    GitHub = "https://github.com/ThembaTshudufhadzo",
                    Skills = "Java, C#, Kotlin, Android Studio, WPF/XAML, RoomDB, OOP, Microsoft Azure (Blob, Table, Queue), SQL, PL/SQL, RESTful APIs, Systems Analysis, RBAC, SDLC, Google AI Essentials",

                    Experience = new List<WorkExperience>
                    {
                        new WorkExperience
                        {
                            Company = "EthnoLab",
                            Role = "Freelance Qualitative Transcriber & Audio Data Analyst",
                            Duration = "Dec 2019 – Nov 2023",
                            Description = "Transcribed and verified extensive multi-speaker audio recordings and qualitative focus group sessions with high verbatim accuracy. Categorized participant feedback and synthesized qualitative findings into structured data summaries to support corporate consumer sentiment audits."
                        }
                    },
                    Projects = new List<ProjectItem>
                    {
                        new ProjectItem
                        {
                            Name = "Enterprise Cloud Solutions — ABC Retails",
                            Description = "Architected a cloud-connected commerce infrastructure leveraging multi-tier Azure Blob, Table, and Queue storage with decoupled message processing pipelines.",
                            GitHubLink = "https://github.com/ThembaTshudufhadzo/ABCRetailsPOEPart3Final"
                        },
                        new ProjectItem
                        {
                            Name = "Contract Monthly Claims System (CMCS)",
                            Description = "Developed a web claim portal automating independent contractor workflows with Role-Based Access Control (RBAC) and strict SQL relational triggers.",
                            GitHubLink = "https://github.com/ThembaTshudufhadzo/PROG6212POE-part3-Final"
                        },
                        new ProjectItem
                        {
                            Name = "SpendWise — Personal Finance Mobile App",
                            Description = "Engineered a native Android personal finance manager utilizing local RoomDB relational tables for offline-first caching and automated budget auditing.",
                            GitHubLink = "https://github.com/ThembaTshudufhadzo"
                        }
                    }
                };

                _context.UserProfiles.Add(profile);
                await _context.SaveChangesAsync();
            }

            return View(profile);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}