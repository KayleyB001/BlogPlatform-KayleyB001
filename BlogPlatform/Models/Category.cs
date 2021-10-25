using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
