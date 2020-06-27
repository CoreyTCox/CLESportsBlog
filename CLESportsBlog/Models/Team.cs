using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLESportsBlog.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string ImageLink { get; set; }
        public virtual ICollection<Content> Contents { get; set; }

        public Team(string name, int id, string imageLink)
        {
            Name = name;
            Id = id;
            ImageLink = imageLink;
        }


        public Team()
        {

        }
    }
}
