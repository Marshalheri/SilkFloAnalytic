using System;

namespace SilkFloAnalytic.Models
{
    public class BaseModel
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public BaseModel()
        {
            this.DateCreated = DateTime.Now;
        }
    }
}
