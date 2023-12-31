﻿using LearnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Entity.Concrete
{
    public class Category : IEntity
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string? AddedBy { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddedDate { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
