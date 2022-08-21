using System;
using System.Collections.Generic;

namespace MolenTaskSolution.Models
{
    public partial class User
    {
        public User()
        {
            FileAttachments = new HashSet<FileAttachment>();
            Projects = new HashSet<Project>();
            Tasks = new HashSet<Task>();
        }

        public int UserId { get; set; }
        public byte[]? Photo { get; set; }
        public string? UserName { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual ICollection<FileAttachment> FileAttachments { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
