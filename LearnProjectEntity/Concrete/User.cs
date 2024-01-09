using LearnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearnProject.Entity.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            this.Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<Product> Products { get; set; }

        [ForeignKey("RoleId")]
        public int RoleId { get; set; }

        public Role Role { get; set; }

    }
}
