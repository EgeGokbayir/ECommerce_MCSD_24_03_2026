using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstracts.Bases
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
    }
}
