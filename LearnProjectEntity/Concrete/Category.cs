using LearnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Entity.Concrete
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AddedBy { get; set; }
        public bool IsActive{ get; set; }
        public DateTime AddedDate { get; set; }

    }
}
