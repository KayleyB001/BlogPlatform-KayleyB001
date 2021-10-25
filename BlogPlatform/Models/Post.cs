using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
