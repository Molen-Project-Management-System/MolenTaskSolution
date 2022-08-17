using System;
using System.Collections.Generic;

namespace MolenTaskSolution.Models
{
    public partial class FileAttachment
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string FileName { get; set; } = null!;
        public string? AttachmentType { get; set; }
        public string? Description { get; set; }
        public byte[]? FileAttachment1 { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual Project? Project { get; set; }
    }
}
