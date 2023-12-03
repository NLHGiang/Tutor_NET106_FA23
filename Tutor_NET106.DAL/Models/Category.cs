﻿namespace Tutor_NET106.DAL.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
