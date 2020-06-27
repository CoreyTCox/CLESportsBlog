using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CLESportsBlog.Models
{
    public class Content
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual int TeamId { get; set; }
        public virtual Team Team { get; set; }

        public Content(int id, string title, string body, string author, DateTime publishDate, int teamId)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
            TeamId = teamId;
        }

        public Content()
        {

        }

        
    }
}
