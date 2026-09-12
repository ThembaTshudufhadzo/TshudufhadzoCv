using System.Collections.Generic;

namespace TshuduCV.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ProfessionalTitle { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string LinkedIn { get; set; } = string.Empty;
        public string GitHub { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public List<ProjectItem> Projects { get; set; } = new();
        public List<WorkExperience> Experience { get; set; } = new();
    }

    public class ProjectItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string GitHubLink { get; set; } = string.Empty;
        public int UserProfileId { get; set; }
    }

    public class WorkExperience
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UserProfileId { get; set; }
    }
}