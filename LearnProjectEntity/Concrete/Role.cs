using LearnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Entity.Concrete
{
    public class Role: IEntity
    {
        public Role() { }

        [Key]
        public int Id { get; set; }

        public bool Status{ get; set; }

        public string Name { get; set; }

        public Guid AddedById { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
