using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsCoverImage { get; set; } = false;

        // Foreign Key
        public int ProductId { get; set; }

        // Navigation Property
        public virtual Product? Product { get; set; }
    }
}