using LearnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Entity.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {
            this.InsertedUser = new User();
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }

        public string? Name { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        public string? Width { get; set; }

        public string? Explanation { get; set; }

        public string?  AddedBy { get; set; }

        public DateTime AddedDate { get; set; }
                
        public Category? Category { get; set; }

        [ForeignKey("InsertedUserId")]
        public Guid? InsertedUserId { get; set; }

        public User? InsertedUser { get; set; }

    }
}
