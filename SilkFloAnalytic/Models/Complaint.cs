using System;

namespace SilkFloAnalytic.Models
{
    public class Complaint : BaseModel
    {
        public long UserId { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
